using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.EntityX;
using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class CustomerBillBreakListForm : BaseForm
    {
        List<ProductInCart> productListCart = new List<ProductInCart>();
        CustomerBill customerBill = new CustomerBill();
        public CustomerBillBreakListForm()
        {
            InitializeComponent();

            dgvCart.AutoGenerateColumns = false;
            CartColAddOne.UseColumnTextForButtonValue = true;
            CartColRemoveOne.UseColumnTextForButtonValue = true;
        }

        private void CustomerBillBreakListForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            PersonListForm personListForm = new PersonListForm();
            personListForm.PERSON_TYPE = Person.CUSTOMER;
            ShowFormAsFixedDialog(this, personListForm);
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
                if (selectedProduct.AvailableQuantity > selectedProduct.SellingQuantity)
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
            e.Control.KeyPress -= new KeyPressEventHandler(NumericFieldKeyPress);
            if (dgvCart.CurrentCell.ColumnIndex == dgvCart.Columns[CartColUnitSellPrice.Name].Index) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumericFieldKeyPress);
                }
            }
        }

        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotalBillAmoutForCart();
        }

        internal void AddProductToCart(ProductInCart productToBeAddedToCart)
        {
            ProductInCart alredyProductInCart = productListCart.Find(x => x.DealerBillBreakupId == productToBeAddedToCart.DealerBillBreakupId);
            if (alredyProductInCart != null)
            {
                MessageBox.Show("Product already availble in cart");
                return;
            }

            // Override box details
            productToBeAddedToCart.QuantityInBox = 1;
            productToBeAddedToCart.TotalBoxes = 1;
            productListCart.Add(productToBeAddedToCart);
            dgvCart.DataSource = null;
            dgvCart.DataSource = productListCart;
            dgvCart.Update();
            dgvCart.Refresh();
            dgvCart.ClearSelection();
            CalculateTotalBillAmoutForCart();
        }

        internal void CalculateTotalBillAmoutForCart()
        {
            decimal totalBillAmountforCart = 0;
            int totalProductQuanityInCart = 0;
            foreach (ProductInCart product in productListCart)
            {
                product.SellingAmount = product.SellingUnitPrice * product.SellingQuantity;
                totalBillAmountforCart += product.SellingAmount;
                totalProductQuanityInCart += product.SellingQuantity;
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
                customerBill.BillDate = DateHelper.GetTodayDateString();
                customerBill.TotalAmount = Convert.ToDecimal(txtTotalBillAmountForCart.Text);
                customerBill.Remarks = txtRemarks.Text;

                customerBill.ResetValidationError();
                customerBill.Validate();
                if (customerBill.EntityState.State != ValidationState.SUCCESS)
                {
                    MessageBox.Show(customerBill.EntityState.StateMessage);
                    return;
                }
                
                SharedRepo.CustomerRepo.SaveCustomerBillBreakupList(customerBill, productListCart);
                MessageBox.Show("Billing completed");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Billing failed");
            }
        }

        private void CustomerBillBreakListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm != null && CallerForm.Name != null)
            {
                if (CallerForm.Name == "CustomerCart")
                {
                    CustomerCartForm customerCartForm = (CustomerCartForm)CallerForm;
                    customerCartForm.Close();
                }
            }
        }

        internal void OnCustomerNameSelected(int customerId, string customerName)
        {
            customerBill.CustomerId = customerId;
            txtCustomerName.Text = customerName;
        }
    }
}
