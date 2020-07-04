using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class ProductListForm : BaseForm
    {
        List<Product> productList;
        Product selectedProduct;

        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            dgvProductList.AutoGenerateColumns = false;
            ColDetails.UseColumnTextForLinkValue = true;
            ColSelect.UseColumnTextForLinkValue = true;

            if (CallerForm != null && CallerForm.Name != null && CallerForm.Name == "BillBreakupForm")
            {
                ColSelect.Visible = true;
            }
            else
            {
                ColSelect.Visible = false;
            }


            LoadProductList();
        }
        private void ProductListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (selectedProduct != null && CallerForm.Name == "BillBreakupForm")
            {
                ((BillBreakupForm)CallerForm).OnProductSelect(selectedProduct.Id, selectedProduct.Name);
            }
        }

        private void txtSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txtSearchProduct_KeyUp(object sender, KeyEventArgs e)
        {
            LoadProductList();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ProductId = 0;
            ShowFormAsFixedDialog(this, productForm);
        }


        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            selectedProduct = (Product)dgvProductList.Rows[e.RowIndex].DataBoundItem;
            if (GetSelectedCellText(dgvProductList, e) == "Details")
            {
                ProductForm productForm = new ProductForm();
                productForm.ProductId = selectedProduct.Id;
                ShowFormAsFixedDialog(this, productForm);
            }
            else if (GetSelectedCellText(dgvProductList, e) == "Select")
            {
                Close(); // close form and on closing call BillBreakupForm method to set product Id and Name
            }
        }

        public void LoadProductList()
        {
            productList = SharedRepo.ProductRepo.GetProductListForAdmin(txtSearchProduct.Text.Trim());
            dgvProductList.DataSource = productList;
            dgvProductList.ClearSelection();
        }

       
    }
}
