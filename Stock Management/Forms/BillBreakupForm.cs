using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillBreakupForm : BaseForm
    {
        BillBreakup BillBreakup;
        public int BillId;
        public int BillBreakupId;
        public BillBreakupForm()
        {
            InitializeComponent();
        }

        private void BillBreakupForm_Load(object sender, EventArgs e)
        {
            EditBillBreakuDetail();
        }

        private void BillBreakupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (CallerForm.Name == "BillBreakupListForm")
            {
                ((BillBreakupListForm)CallerForm).LoadBillBreakupList();
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            ShowFormAsDialog(this, productListForm);
        }

        private void AmountAndQuantity_Changed(object sender, EventArgs e)
        {
            try
            {
                if (numTotalAmount.Value == 0)
                {
                    numUnitPrice.Value = 0;
                }
                else
                {
                    numTotalQuantity.Value = numTotalBoxes.Value * numQuantityInABox.Value;
                    numUnitPrice.Value = numTotalAmount.Value / numTotalQuantity.Value;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSaveBillBreakups_Click(object sender, EventArgs e)
        {
            SaveBillBreakup();
        }

        //internal void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Verify that the pressed key isn't CTRL or any non-numeric digit
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // If you want, you can allow decimal (float) numbers
        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}

        internal void OnProductSelect(int produectId, string productName)
        {
            BillBreakup.ProductId = produectId;
            txtSelectedProductName.Text = productName;
        }

        private void EditBillBreakuDetail()
        {
            //lblDealerName.Text = Session.DealerName;
            Bill bill = SharedRepo.BillRepo.GetByID(BillId);
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
            txtTotalBreakupCount.Text = bill.BillBreakupList.Count.ToString();
            txtTotalBreakupAmount.Text = bill.BillBreakupList.Sum(x => x.TotalAmount).ToString();

            if (BillBreakupId != 0)
            {
                BillBreakup = SharedRepo.BillBreakupRepo.GetByID(BillBreakupId);
            }
            else
            {
                BillBreakup = new BillBreakup();
                BillBreakup.BillId = BillId;
                BillBreakup.EntryDate = DateHelper.GetTodayDateString();
            }
        }

        private void SaveBillBreakup()
        {
            BillBreakup.EntityState = new ValidationState();
            BillBreakup.TotalAmount = numTotalAmount.Value;
            BillBreakup.QuantityInBox = (int)numQuantityInABox.Value;
            BillBreakup.TotalBoxes = (int)numTotalBoxes.Value;
            BillBreakup.TotalQuantity = (int)numTotalQuantity.Value;
            BillBreakup.UnitPrice = Math.Round(numUnitPrice.Value,2);
            BillBreakup.ValidateBillBreakup();
            if (BillBreakup.EntityState.State == ValidationState.SUCCESS)
            {
                SharedRepo.BillBreakupRepo.Save(BillBreakup);
                Close();
            }
            else
            {
                MessageBox.Show(BillBreakup.EntityState.StateMessage);
            }
        }



        //private void CalculateTotalQuantityUnitPrice()
        //{
        //    try
        //    {
        //        if (numTotalAmount.Value == 0)
        //        {
        //            numUnitPrice.Value = 0;
        //        }
        //        else
        //        {
        //            numTotalQuantity.Value = numTotalBoxes.Value * numQuantityInABox.Value;
        //            numUnitPrice.Value = numTotalAmount.Value / numTotalQuantity.Value;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //private void ValidateNumber()
        //{
        //    if (!NumberHelper.IsValidNumber(txtBillBreakupAmount.Text))
        //    {
        //        BillBreakup.EntityState.State = ValidationState.ERROR;
        //        BillBreakup.EntityState.StateMessage += "Bill details amount is not a valid number";
        //    }
        //    if (!NumberHelper.IsValidNumber(txtTotalBoxes.Text))
        //    {
        //        BillBreakup.EntityState.State = ValidationState.ERROR;
        //        BillBreakup.EntityState.StateMessage += "Total boxes is not a valid number";
        //    }
        //    if (!NumberHelper.IsValidNumber(txtQuantityInBox.Text))
        //    {
        //        BillBreakup.EntityState.State = ValidationState.ERROR;
        //        BillBreakup.EntityState.StateMessage += "Quantity in a box is not a valid number";
        //    }
        //    if (!NumberHelper.IsValidNumber(txtTotalQuantity.Text))
        //    {
        //        BillBreakup.EntityState.State = ValidationState.ERROR;
        //        BillBreakup.EntityState.StateMessage += "Total Quanity is not a valid number";
        //    }
        //    if (!NumberHelper.IsValidNumber(txtUnitPrice.Text))
        //    {
        //        BillBreakup.EntityState.State = ValidationState.ERROR;
        //        BillBreakup.EntityState.StateMessage += "Unit Price a valid number";
        //    }
        //}



    }
}
