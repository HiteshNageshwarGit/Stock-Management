using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.EntityX;
using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class SellForm : Form
    {
        List<ProductInCart> productListCart = new List<ProductInCart>();
        public SellForm()
        {
            InitializeComponent();

            dgvProductList.AutoGenerateColumns = false;
            ColAddToCart.UseColumnTextForButtonValue = true;

            dgvCart.AutoGenerateColumns = false;
            CartColAddOne.UseColumnTextForButtonValue = true;
            CartColRemoveOne.UseColumnTextForButtonValue = true;
            //Shared.SharedRepo.ProductRepo.GetProductListForSelling("p");
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
                AddProductToCart(selectedProduct);
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                return;
            }

            if (dgvCart.Columns[e.ColumnIndex].Name == CartColAddOne.Name)
            {
                ProductInCart selectedProduct = (ProductInCart)dgvCart.Rows[e.RowIndex].DataBoundItem;
                if (selectedProduct.TotalQuantity > selectedProduct.SellingQuantity)
                {
                    selectedProduct.SellingQuantity++;
                    CalculateTotalBillAmoutForCart();
                }
            }
            else if (dgvCart.Columns[e.ColumnIndex].Name == CartColRemoveOne.Name)
            {
                ProductInCart selectedProduct = (ProductInCart)dgvCart.Rows[e.RowIndex].DataBoundItem;
                if (selectedProduct.SellingQuantity > 0)
                {
                    selectedProduct.SellingQuantity--;
                    CalculateTotalBillAmoutForCart();
                }
            }
        }

        private void dgvCart_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvCart.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void LoadProductListWithPrice()
        {
            List<ProductInCart> list = SharedRepo.ProductRepo.GetProductListForSelling(txtProductName.Text.Trim());
            dgvProductList.DataSource = list;
            dgvProductList.ClearSelection();
        }

        private void AddProductToCart(ProductInCart productToBeAddedToCart)
        {
            ProductInCart alredyProductInCart = productListCart.Find(x => x.DealerBillBreakupId == productToBeAddedToCart.DealerBillBreakupId);
            if (alredyProductInCart != null)
            {
                MessageBox.Show("Product already availble in cart");
                return;
            }
            dgvCart.DataSource = null;

            // Override box details

            dgvCart.DataSource = productListCart;
            productListCart.Add(productToBeAddedToCart.ShallowCopy());
            dgvCart.Update();
            dgvCart.Refresh();
            dgvCart.ClearSelection();
            CalculateTotalBillAmoutForCart();
        }

        private void CalculateTotalBillAmoutForCart()
        {
            decimal totalBillAmountforCart = 0;
            int totalProductQuanityInCart = 0;
            foreach (ProductInCart product in productListCart)
            {
                product.SellingAmount = product.SellingUnitPrice * product.SellingQuantity;
                totalBillAmountforCart += product.SellingAmount;
            }
            dgvCart.Refresh();

            txtTotalBillAmountForCart.Text = totalBillAmountforCart.ToString();
            txtTotalProductCountInCart.Text = productListCart.Count.ToString();
            txtTotalProductQuantityInCart.Text = totalProductQuanityInCart.ToString();

        }

        private void btnFinishBilling_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerBill customerBill = new CustomerBill();
                customerBill.BillDate = DateHelper.GetTodayDateString();
                customerBill.TotalAmount = Convert.ToDecimal(txtTotalBillAmountForCart.Text);
                customerBill.CustomerId = -1;

                if (customerBill.Id <= 0)
                {
                    customerBill.Id = SharedRepo.CustomerRepo.GetDefaultCustomer().Id;
                }

                SharedRepo.CustomerRepo.SaveCustomerBillBreakupList(customerBill, productListCart);
                MessageBox.Show("Billing completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Billing failed");
            }
        }


    }
}
