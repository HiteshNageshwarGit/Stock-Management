using Stock_Management.Shared;
using StockEntity.EntityX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class ProductListForm : BaseForm
    {
        public ProductListForm()
        {
            InitializeComponent();
            SetDataGridViewProperties(dgvProductList);
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            dgvProductList.AutoGenerateColumns = false;
            ColDetails.UseColumnTextForLinkValue = true;
            ColSelect.UseColumnTextForLinkValue = true;

            if (CallerForm != null && CallerForm.Name != null && CallerForm.Name == "DealerBillBreakupForm")
            {
                ColSelect.Visible = true;
            }
            else
            {
                ColSelect.Visible = false;
            }

            LoadProductList();
        }

        private void txtSearchProduct_KeyUp(object sender, KeyEventArgs e)
        {
            LoadProductList();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(0);
            ShowFormAsFixedDialog(this, productForm);
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            ProductReport selectedProduct = (ProductReport)dgvProductList.Rows[e.RowIndex].DataBoundItem;
            if (GetSelectedCellText(dgvProductList, e) == "Details")
            {
                ProductForm productForm = new ProductForm(selectedProduct.Id);
                ShowFormAsFixedDialog(this, productForm);
            }
            else if (GetSelectedCellText(dgvProductList, e) == "Select")
            {
                if (CallerForm == null && CallerForm.Name == null)
                {
                    return;
                }
                else if (selectedProduct != null && CallerForm.Name == "DealerBillBreakupForm")
                {
                    ((DealerBillBreakupForm)CallerForm).OnProductSelect(selectedProduct.Id, selectedProduct.ProductName);
                }
                Close(); // close form and on closing call BillBreakupForm method to set product Id and Name
            }
        }

        public void LoadProductList()
        {
            List<ProductReport> productList = SharedRepo.DBRepo.GetProductListForAdmin(txtSearchProduct.Text.Trim());
            dgvProductList.DataSource = productList;
            dgvProductList.ClearSelection();
        }

        private void dgvProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == ColAvailableQuantity.Index)
            {
                ProductReport productReport = (ProductReport)dgvProductList.Rows[e.RowIndex].DataBoundItem;
                if (productReport.AvailableQuantity <= productReport.LowerLimit)
                {
                    e.CellStyle.BackColor = RAG_Red;
                }
                else if (productReport.AvailableQuantity >= productReport.UpperLimit)
                {
                    e.CellStyle.BackColor = RAG_Green;
                }
                else
                {
                    e.CellStyle.BackColor = RAG_Amber;
                }
            }
            DataGridView_Selected_Cell_CellFormatting(sender, e);
        }
    }
}
