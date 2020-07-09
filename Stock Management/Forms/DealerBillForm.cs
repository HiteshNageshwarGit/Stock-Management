using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillForm : BaseForm
    {
        public int PERSON_TYPE { get; set; }
        public int BILL_ID { get; set; }

        public DealerBill dealerBill;
        Dealer dealer;
        public int DealerId;

        public DealerBillForm()
        {
            InitializeComponent();
            dtBillDate.CustomFormat = DateHelper.DATE_FORMAT;
            dtBillEntryDate.CustomFormat = DateHelper.DATE_FORMAT;
            dtBillDate.MaxDate = DateTime.Now;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            EditBill();
        }

        private void BillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (CallerForm.Name == "BillListForm")
            {
                ((BillListForm)CallerForm).LoadBillList();
            }
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            SaveBill();
        }

        private void EditBill()
        {
            dealer = SharedRepo.DealerRepo.GetByID(DealerId);
            if (dealer == null)
            {
                MessageBox.Show("Dealer details not found");
                Close();
                return;
            }
            txtDealerName.Text = dealer.Name;

            if (BILL_ID != 0)
            {
                Text = "Edit Dealer Bill";
                dealerBill = SharedRepo.DealerBillRepo.GetByID(BILL_ID);
                dtBillEntryDate.Value = DateHelper.GetDateObject(dealerBill.EntryDate);
                dtBillDate.Value = DateHelper.GetDateObject(dealerBill.BillDate);
                numBillAmount.Value = dealerBill.TotalAmount;
                txtRemarks.Text = dealerBill.Remarks;
            }
            else
            {
                Text = "Add Dealer Bill";
                dealerBill = new DealerBill();
                dtBillEntryDate.Value = DateHelper.GetTodayDateObject();
            }
        }

        private void SaveBill()
        {
            dealerBill.ResetValidationError();
            dealerBill.DealerId = dealer.Id;
            dealerBill.EntryDate = DateHelper.GetDateString(dtBillEntryDate.Value); //lblEntyDate.Text;
            dealerBill.BillDate = DateHelper.GetDateString(dtBillDate.Value);
            dealerBill.TotalAmount = numBillAmount.Value;
            dealerBill.Remarks = txtRemarks.Text;
            dealerBill.Validate();
            if (dealerBill.EntityState.State != ValidationState.SUCCESS)
            {
                MessageBox.Show(dealerBill.EntityState.StateMessage);
                return;
            }
            SharedRepo.DealerBillRepo.Save((DealerBill)dealerBill);
            Close();
        }


    }
}
