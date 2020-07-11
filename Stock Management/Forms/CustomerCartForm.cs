using Stock_Management.Shared;
using StockEntity.EntityX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class CustomerCartForm : BaseForm
    {
        CustomerBillBreakListForm customerBillBreakListForm = new CustomerBillBreakListForm();
        public CustomerCartForm()
        {
            InitializeComponent();

            dgvProductList.AutoGenerateColumns = false;
            ColAddToCart.UseColumnTextForButtonValue = true;
            ShowFormInPanel(this, pnlCustomerBillBreakup, customerBillBreakListForm);
        }

        private void SellForm_Load(object sender, System.EventArgs e)
        {

        }

        private void SellForm_Shown(object sender, System.EventArgs e)
        {
            LoadProductListWithPrice();
        }

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
            LoadProductListWithPrice();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                return;
            }

            if (dgvProductList.Columns[e.ColumnIndex].Name == ColAddToCart.Name)
            {
                ProductInCart selectedProduct = (ProductInCart)dgvProductList.Rows[e.RowIndex].DataBoundItem;
                customerBillBreakListForm.AddProductToCart(selectedProduct.ShallowCopy());
            }
        }

        private void LoadProductListWithPrice()
        {
            List<ProductInCart> list = SharedRepo.DBRepo.GetProductListForSelling(txtProductName.Text.Trim());
            dgvProductList.DataSource = list;
            dgvProductList.ClearSelection();
        }

        internal void OnCustomerBillingFinish()
        {
            LoadProductListWithPrice();
            customerBillBreakListForm = new CustomerBillBreakListForm();
            ShowFormInPanel(this, pnlCustomerBillBreakup, customerBillBreakListForm);
        }

    }
}
