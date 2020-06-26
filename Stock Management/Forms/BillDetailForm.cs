using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillDetailForm : BaseForm
    {
        BillDetail billDetail;
        public int BillId;
        public int BillDetailId;
        //public int DealerId;
        public BillDetailForm()
        {
            InitializeComponent();
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {
            EditBill();
        }

        internal void LoadProductListForSuggestions()
        {

        }

        private void BillDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (CallerForm.Name == "DealerListForm")
            {
                ((DealerListForm)CallerForm).LoadBillList();
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            ShowFormAsDialog(this, productListForm);
        }

        private void btnSaveBillDetails_Click(object sender, EventArgs e)
        {
            SaveBillDEtail();
        }

        internal void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        internal void OnProductSelect(int produectId, string productName)
        {
            billDetail.ProductId = produectId;
            lblSelectedProductName.Text = productName;
        }

        private void EditBill()
        {
            //lblDealerName.Text = Session.DealerName;
            Bill bill = Session.BillRepo.GetByID(BillId);
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

            lblDealerName.Text = bill.Dealer.Name;
            lblBillDate.Text = bill.BillDate;
            lblBillAmount.Text = bill.TotalAmount.ToString();
            lblBillRemarks.Text = bill.Remarks;

            if (BillDetailId != 0)
            {
                billDetail = Session.BillDetailRepo.GetByID(BillDetailId);
                //lblEntyDate.Text = bill.EntryDate.ToString();
                //dtBillDate.Value = DateHelper.GetDateObject(bill.BillDate);
                //txtTotalAmount.Text = Convert.ToString(bill.TotalAmount);
                //txtRemarks.Text = bill.Remarks;                //lblEntyDate.Text = bill.EntryDate.ToString();
                //dtBillDate.Value = DateHelper.GetDateObject(bill.BillDate);
                //txtTotalAmount.Text = Convert.ToString(bill.TotalAmount);
                //txtRemarks.Text = bill.Remarks;
            }
            else
            {
                billDetail = new BillDetail();
                billDetail.BillId = BillId;
                billDetail.EntryDate = DateHelper.GetTodayDateString();
            }
        }

        private void SaveBillDEtail()
        {
            billDetail.EntityState = new ValidationState();
            ValidateNumber();
            if (billDetail.EntityState.State == ValidationState.ERROR)
            {
                MessageBox.Show(billDetail.EntityState.StateMessage);
            }

            billDetail.TotalAmount = float.Parse(txtBillDetailAmount.Text);


            billDetail.ValidateBillDetail();
            if (billDetail.EntityState.State == ValidationState.SUCCESS)
            {
                Session.BillDetailRepo.Save(billDetail);
                Close();
            }
            else
            {
                MessageBox.Show(billDetail.EntityState.StateMessage);
            }
        }

        private void ValidateNumber()
        {
            if (!NumberHelper.IsValidNumber(txtBillDetailAmount.Text))
            {
                billDetail.EntityState.State = ValidationState.ERROR;
                billDetail.EntityState.StateMessage += "Bill details amount is not a valid number";
            }
            if (!NumberHelper.IsValidNumber(txtTotalBoxes.Text))
            {
                billDetail.EntityState.State = ValidationState.ERROR;
                billDetail.EntityState.StateMessage += "Total boxes is not a valid number";
            }
            if (!NumberHelper.IsValidNumber(txtQuantityInBox.Text))
            {
                billDetail.EntityState.State = ValidationState.ERROR;
                billDetail.EntityState.StateMessage += "Quantity in a box is not a valid number";
            }
            if (!NumberHelper.IsValidNumber(txtTotalQuantity.Text))
            {
                billDetail.EntityState.State = ValidationState.ERROR;
                billDetail.EntityState.StateMessage += "Total Quanity is not a valid number";
            }
            if (!NumberHelper.IsValidNumber(txtUnitPrice.Text))
            {
                billDetail.EntityState.State = ValidationState.ERROR;
                billDetail.EntityState.StateMessage += "Unit Price a valid number";
            }
        }



    }
}
