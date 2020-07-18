using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.EntityX;
using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class CustomerCartDetailForm : BaseForm
    {
        private List<ProductInCart> productListCart = new List<ProductInCart>();
        private CustomerBill customerBill = new CustomerBill();

        decimal previousSellingPrice;
        int previousQuantityInCart;

        public CustomerCartDetailForm()
        {
            InitializeComponent();
            PrepareTooltips(this);

            dgvCart.AutoGenerateColumns = false;
            CartColAddOne.UseColumnTextForButtonValue = true;
            CartColRemoveOne.UseColumnTextForButtonValue = true;
            SetDataGridViewProperties(dgvCart);
        }

        private void CustomerBillBreakListForm_Load(object sender, EventArgs e)
        {
            SetFormBehaviour();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            OpenPersonFindForm();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            ProductInCart selectedProduct = (ProductInCart)dgvCart.Rows[e.RowIndex].DataBoundItem;
            if (dgvCart.Columns[e.ColumnIndex].Name == CartColAddOne.Name)
            {
                if (selectedProduct.AvailableQuantity > selectedProduct.SellingQuantity)
                {
                    selectedProduct.SellingQuantity++;
                    CalculateTotalBillAmoutForCart();
                }
            }
            else if (dgvCart.Columns[e.ColumnIndex].Name == CartColRemoveOne.Name)
            {
                if (selectedProduct.SellingQuantity == 1)
                {
                    RemoveProductFromCart(selectedProduct.DealerBillBreakupId);
                }
                else if (selectedProduct.SellingQuantity > 1)
                {
                    selectedProduct.SellingQuantity--;
                    CalculateTotalBillAmoutForCart();
                }
            }
        }

        private void dgvCart_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumericContyrolKeyPress);
            if (dgvCart.CurrentCell.ColumnIndex == dgvCart.Columns[CartColUnitSellPrice.Name].Index // Edit Unit selling price
               || dgvCart.CurrentCell.ColumnIndex == dgvCart.Columns[CartColProductQuantityInCart.Name].Index // Edit product quantity in cart 
               )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumericContyrolKeyPress); // allow only numeric keys
                }
            }

            if (dgvCart.CurrentCell.ColumnIndex == dgvCart.Columns[CartColUnitSellPrice.Name].Index)
            {
                previousSellingPrice = decimal.Parse(dgvCart.CurrentCell.Value.ToString()); // store previous value to restore when validation failed
            }
            else if (dgvCart.CurrentCell.ColumnIndex == dgvCart.Columns[CartColProductQuantityInCart.Name].Index)
            {
                previousQuantityInCart = int.Parse(dgvCart.CurrentCell.Value.ToString()); // store previous value to restore when validation failed
            }
        }

        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns[CartColUnitSellPrice.Name].Index) // Editing Unit selling price
            {
                if (decimal.Parse(dgvCart.CurrentCell.Value.ToString())
                    <= decimal.Parse(dgvCart.Rows[e.RowIndex].Cells[dgvCart.Columns[CartColUnitPrice.Name].Index].Value.ToString()))
                {
                    MessageBox.Show("Selling price is tool low");
                    dgvCart.CurrentCell.Value = previousSellingPrice;
                    return;
                }
            }
            else if (e.ColumnIndex == dgvCart.Columns[CartColProductQuantityInCart.Name].Index) // Edit product quantity in cart 
            {
                if (int.Parse(dgvCart.CurrentCell.Value.ToString()) == 0)
                {
                    ProductInCart selectedProduct = (ProductInCart)dgvCart.Rows[e.RowIndex].DataBoundItem;
                    if (!RemoveProductFromCart(selectedProduct.DealerBillBreakupId))
                    {
                        dgvCart.CurrentCell.Value = previousQuantityInCart;
                    }
                    return;
                }

                else if (int.Parse(dgvCart.CurrentCell.Value.ToString()) >
                    int.Parse(dgvCart.Rows[e.RowIndex].Cells[dgvCart.Columns[CartColTotalQuantity.Name].Index].Value.ToString()))
                {
                    MessageBox.Show("Selling Quantity can not be more than Available Quantity");
                    dgvCart.CurrentCell.Value = previousQuantityInCart;
                    return;
                }
            }

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
            CalculateTotalBillAmoutForCart();
            RefreshCustomerCart();
        }

        internal bool RemoveProductFromCart(int dealerBillBreakupId)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete", "Delete from cart", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var productToRemove = productListCart.Where(x => x.DealerBillBreakupId == dealerBillBreakupId).First();
                productListCart.Remove(productToRemove);
                RefreshCustomerCart();
                return true;
            }
            else
            {
                return false;
            }
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
            RefreshCustomerCart();

            txtTotalBillAmountForCart.Text = totalBillAmountforCart.ToString();
            txtTotalProductCountInCart.Text = productListCart.Count.ToString();
            txtTotalProductQuantityInCart.Text = totalProductQuanityInCart.ToString();
        }

        private void btnFinishBilling_Click(object sender, EventArgs e)
        {
            FinalizeCustomerBill();
        }

        internal void OnCustomerNameSelected(int customerId, string customerName)
        {
            customerBill.CustomerId = customerId;
            txtCustomerName.Text = customerName;
        }

        private void SetFormBehaviour()
        {

        }

        internal void OpenPersonFindForm()
        {
            PersonListForm personListForm = new PersonListForm(PersonBase.CUSTOMER);
            ShowFormAsFixedDialog(this, personListForm);
        }

        internal void FinalizeCustomerBill()
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

                SharedRepo.DBRepo.SaveCustomerBillBreakupList(customerBill, productListCart);
                MessageBox.Show("Billing completed");

                if (CallerForm != null && CallerForm.Name != null)
                {
                    if (CallerForm.Name == "CustomerCartForm")
                    {
                        CustomerCartForm customerCartForm = (CustomerCartForm)CallerForm;
                        customerCartForm.OnCustomerBillingFinish();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Billing failed");
            }
        }

        internal void RefreshCustomerCart()
        {
            BaseEntity.ResetRowNumberInList(productListCart);
            dgvCart.DataSource = null;
            dgvCart.DataSource = productListCart;
            dgvCart.Update();
            dgvCart.Refresh();
            dgvCart.ClearSelection();
            //CalculateTotalBillAmoutForCart();
        }

    }
}
