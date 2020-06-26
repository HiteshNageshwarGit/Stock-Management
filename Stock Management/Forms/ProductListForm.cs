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

            LoadProductList();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ProductId = 0;
            ShowFormAsDialog(this, productForm);
        }

        public void LoadProductList()
        {
            productList = Session.ProductRepository.GetProductList();
            dgvProductList.DataSource = productList;
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProduct = (Product)dgvProductList.Rows[e.RowIndex].DataBoundItem;
            if (GetSelectedCellText(dgvProductList, e) == "Details")
            {
                ProductForm productForm = new ProductForm();
                productForm.ProductId = selectedProduct.Id;
                ShowFormAsDialog(this, productForm);
            }
            else if (GetSelectedCellText(dgvProductList, e) == "Select")
            {
                Close(); // close form and on closing call BillDetailForm method to set product Id and Name
            }
        }

        private void ProductListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (selectedProduct != null && CallerForm.Name == "BillDetailForm")
            {
                ((BillDetailForm)CallerForm).OnProductSelect(selectedProduct.Id, selectedProduct.Name);
            }
        }
    }
}
