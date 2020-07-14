using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillBreakupForm : BaseForm
    {
        DealerBillBreakup dealerBillBreakup;
        public int BillId;
        public int BillBreakupId;
        public DealerBillBreakupForm()
        {
            InitializeComponent();
            PrepareTooltips(this);
        }

        private void BillBreakupForm_Load(object sender, EventArgs e)
        {
            EditBillBreakuDetail();
        }

        private void BillBreakupForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                OpenSearchProductForm();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                SaveBillBreakup();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            OpenSearchProductForm();
        }

        private void NumericControl_ValueChange(object sender, EventArgs e)
        {
            CalculateQuantityAndUnitPrice();
        }
        private void NumericControl_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateQuantityAndUnitPrice();
        }

        private void NumericControlWithoutDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericControlWithoutDecimalKeyPress(sender, e);
        }

        private void btnSaveBillBreakups_Click(object sender, EventArgs e)
        {
            SaveBillBreakup();
        }

        internal void OnProductSelect(int produectId, string productName)
        {
            dealerBillBreakup.ProductId = produectId;
            txtSelectedProductName.Text = productName;
        }

        private void EditBillBreakuDetail()
        {
            DealerBill bill = SharedRepo.DBRepo.GetDealerBillByID(BillId);
            if (bill == null)
            {
                MessageBox.Show("Bill not found");
                Close();
                return;
            }
            else if (bill.Dealer == null)
            {
                MessageBox.Show("Dealer not found");
                Close();
                return;
            }

            txtDealerName.Text = bill.Dealer.Name;
            txtBillDate.Text = bill.BillDate;
            txtTotalBillAmount.Text = bill.TotalAmount.ToString();
            txtTotalBreakupCount.Text = bill.DealerBillBreakupList.Count.ToString();
            decimal breakupSum = bill.DealerBillBreakupList.Sum(x => x.TotalAmount);
            txtTotalBreakupAmount.Text = breakupSum.ToString();

            if (breakupSum == bill.TotalAmount)
            {
                txtTotalBreakupAmount.BackColor = System.Drawing.Color.LightGreen;
            }
            else if (breakupSum > bill.TotalAmount)
            {
                txtTotalBreakupAmount.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtTotalBreakupAmount.BackColor = System.Drawing.Color.Orange;
            }


            if (BillBreakupId != 0)
            {
                Text = "Edit Dealer Bill Breakup";
                dealerBillBreakup = SharedRepo.DBRepo.GetDealerBillBreakupByID(BillBreakupId);
                if (dealerBillBreakup == null)
                {
                    btnSaveBillBreakups.Enabled = false;
                    return;
                }
                else
                {
                    if (dealerBillBreakup.Product != null)
                    {
                        txtSelectedProductName.Text = dealerBillBreakup.Product.Name;
                    }
                    numTotalAmount.Value = dealerBillBreakup.TotalAmount;
                    numTotalBoxes.Value = dealerBillBreakup.TotalBoxes;
                    numQuantityInABox.Value = dealerBillBreakup.QuantityInBox;
                    numTotalQuantity.Value = dealerBillBreakup.TotalQuantity;
                    numAvailableQuantity.Value = dealerBillBreakup.AvailableQuantity;
                    numUnitPrice.Value = dealerBillBreakup.UnitPrice;
                    numUnitSellingPrice.Value = dealerBillBreakup.UnitSellPrice;
                }
            }
            else
            {
                Text = "Add Dealer Bill Breakup";
                dealerBillBreakup = new DealerBillBreakup();
                dealerBillBreakup.DealerBillId = BillId;
                dealerBillBreakup.EntryDate = DateHelper.GetTodayDateString();
            }
        }

        private void SaveBillBreakup()
        {
            dealerBillBreakup.EntityState = new ValidationState();
            dealerBillBreakup.TotalAmount = Math.Round(numTotalAmount.Value, 2);
            dealerBillBreakup.QuantityInBox = (int)numQuantityInABox.Value;
            dealerBillBreakup.TotalBoxes = (int)numTotalBoxes.Value;
            dealerBillBreakup.TotalQuantity = (int)numTotalQuantity.Value;
            dealerBillBreakup.UnitPrice = Math.Round(numUnitPrice.Value, 2);
            dealerBillBreakup.UnitSellPrice = numUnitSellingPrice.Value;
            dealerBillBreakup.AvailableQuantity = (int)numAvailableQuantity.Value;
            dealerBillBreakup.ValidateDealerBillBreakup();

            if (dealerBillBreakup.EntityState.State == ValidationState.SUCCESS)
            {
                SharedRepo.DBRepo.SaveDealerBillBreakup(dealerBillBreakup);
                if (CallerForm == null || CallerForm.Name == null)
                {
                    return;
                }
                else if (CallerForm.Name == "DealerBillBreakupListForm")
                {
                    ((DealerBillBreakupListForm)CallerForm).LoadBillBreakupList(true);
                }
                Close();
            }
            else
            {
                MessageBox.Show(dealerBillBreakup.EntityState.StateMessage);
            }
        }


        private void CalculateQuantityAndUnitPrice()
        {
            try
            {
                decimal totalAmount = decimal.Parse(numTotalAmount.Controls[1].Text); // Getting value direct from control with decimal resets cursor position to 0 indedx
                decimal totalBoxes = decimal.Parse(numTotalBoxes.Controls[1].Text);
                decimal quantityInABox = decimal.Parse(numQuantityInABox.Controls[1].Text);

                numTotalQuantity.Value = totalBoxes * quantityInABox;
                numAvailableQuantity.Value = numTotalQuantity.Value;
                if (totalAmount == 0)
                {
                    numUnitPrice.Value = 0;
                }
                else
                {
                    numUnitPrice.Value = totalAmount / numTotalQuantity.Value;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void OpenSearchProductForm()
        {
            ProductListForm productListForm = new ProductListForm();
            ShowFormAsFixedDialog(this, productListForm);
        }
    }
}
