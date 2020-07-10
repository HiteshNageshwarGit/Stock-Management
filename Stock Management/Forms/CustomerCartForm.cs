using Stock_Management.Shared;
using StockEntity.EntityX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class CustomerCartForm : BaseForm
    {
        //List<ProductInCart> productListCart = new List<ProductInCart>();
        CustomerBillBreakListForm customerBillBreakListForm = new CustomerBillBreakListForm();
        public CustomerCartForm()
        {
            InitializeComponent();

            dgvProductList.AutoGenerateColumns = false;
            ColAddToCart.UseColumnTextForButtonValue = true;

            //dgvCart.AutoGenerateColumns = false;
            //CartColAddOne.UseColumnTextForButtonValue = true;
            //CartColRemoveOne.UseColumnTextForButtonValue = true;
            ShowFormInPanel(pnlCustomerBillBreakup, customerBillBreakListForm);

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
                // AddProductToCart(selectedProduct.ShallowCopy());
                customerBillBreakListForm.AddProductToCart(selectedProduct.ShallowCopy());
                //pnlCustomerBillBreakup.Refresh();
                //pnlCustomerBillBreakup.Update();
                //pnlCustomerBillBreakup.Invalidate();
            }
            //this.Invalidate();
        }

        //private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1 && e.ColumnIndex == -1)
        //    {
        //        return;
        //    }

        //    if (dgvCart.Columns[e.ColumnIndex].Name == CartColAddOne.Name)
        //    {
        //        ProductInCart selectedProduct = (ProductInCart)dgvCart.Rows[e.RowIndex].DataBoundItem;
        //        if (selectedProduct.TotalQuantity > selectedProduct.SellingQuantity)
        //        {
        //            selectedProduct.SellingQuantity++;
        //            //CalculateTotalBillAmoutForCart();
        //            customerBillBreakListForm.CalculateTotalBillAmoutForCart();
        //        }
        //    }
        //    else if (dgvCart.Columns[e.ColumnIndex].Name == CartColRemoveOne.Name)
        //    {
        //        ProductInCart selectedProduct = (ProductInCart)dgvCart.Rows[e.RowIndex].DataBoundItem;
        //        if (selectedProduct.SellingQuantity > 0)
        //        {
        //            selectedProduct.SellingQuantity--;
        //            customerBillBreakListForm.CalculateTotalBillAmoutForCart();
        //        }
        //    }
        //}

        //private void dgvCart_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    e.Control.KeyPress -= new KeyPressEventHandler(SellingUnitPriceKeyPress);
        //    if (dgvCart.CurrentCell.ColumnIndex == dgvCart.Columns[CartColUnitSellPrice.Name].Index) //Desired Column
        //    {
        //        TextBox tb = e.Control as TextBox;
        //        if (tb != null)
        //        {
        //            tb.KeyPress += new KeyPressEventHandler(SellingUnitPriceKeyPress);
        //        }
        //    }
        //}

        //private void SellingUnitPriceKeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        public void LoadProductListWithPrice()
        {
            List<ProductInCart> list = SharedRepo.DBRepo.GetProductListForSelling(txtProductName.Text.Trim());
            dgvProductList.DataSource = list;
            dgvProductList.ClearSelection();
        }

        //private void AddProductToCart(ProductInCart productToBeAddedToCart)
        //{
        //    ProductInCart alredyProductInCart = productListCart.Find(x => x.DealerBillBreakupId == productToBeAddedToCart.DealerBillBreakupId);
        //    if (alredyProductInCart != null)
        //    {
        //        MessageBox.Show("Product already availble in cart");
        //        return;
        //    }

        //    // Override box details
        //    productToBeAddedToCart.QuantityInBox = 1;
        //    productToBeAddedToCart.TotalBoxes = 1;
        //    productListCart.Add(productToBeAddedToCart);
        //    dgvCart.DataSource = null;
        //    dgvCart.DataSource = productListCart;
        //    dgvCart.Update();
        //    dgvCart.Refresh();
        //    dgvCart.ClearSelection();
        //    CalculateTotalBillAmoutForCart();
        //}

        //private void CalculateTotalBillAmoutForCart()
        //{
        //    decimal totalBillAmountforCart = 0;
        //    int totalProductQuanityInCart = 0;
        //    foreach (ProductInCart product in productListCart)
        //    {
        //        product.SellingAmount = product.SellingUnitPrice * product.SellingQuantity;
        //        totalBillAmountforCart += product.SellingAmount;
        //        totalProductQuanityInCart += product.SellingQuantity;
        //    }
        //    dgvCart.Refresh();

        //    txtTotalBillAmountForCart.Text = totalBillAmountforCart.ToString();
        //    txtTotalProductCountInCart.Text = productListCart.Count.ToString();
        //    txtTotalProductQuantityInCart.Text = totalProductQuanityInCart.ToString();

        //}

        //private void btnFinishBilling_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CustomerBill customerBill = new CustomerBill();
        //        customerBill.BillDate = DateHelper.GetTodayDateString();
        //        customerBill.TotalAmount = Convert.ToDecimal(txtTotalBillAmountForCart.Text);
        //        customerBill.Remarks = txtRemarks.Text;
        //        customerBill.CustomerId = -1;

        //        if (customerBill.CustomerId <= 0)
        //        {
        //            customerBill.CustomerId = SharedRepo.CustomerRepo.GetDefaultCustomer().Id;
        //        }

        //        SharedRepo.CustomerRepo.SaveCustomerBillBreakupList(customerBill, productListCart);
        //        MessageBox.Show("Billing completed");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Billing failed");
        //    }
        //}


        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
