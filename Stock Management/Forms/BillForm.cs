using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillForm : BaseForm
    {
        public int PERSON_TYPE { get; set; }
        public int BILL_ID { get; set; }

        public DealerBill dealerBill;
        Dealer dealer;
        public int DealerId;

        public BillForm()
        {
            InitializeComponent();
            dtBillDate.CustomFormat = DateHelper.DATE_FORMAT;
            dtBillEntryDate.CustomFormat = DateHelper.DATE_FORMAT;
            dtBillDate.MaxDate = DateTime.Now;
            //this.EnumerateChildren();
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
            else if (CallerForm.Name == "DealerListForm")
            {
                ((DealerListForm)CallerForm).LoadBillList();
            }
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            SaveBill();
        }

        private void EditBill()
        {
            //lblDealerName.Text = Session.DealerName;
            dealer = SharedRepo.DealerRepo.GetByID(DealerId);
            if (dealer == null)
            {
                MessageBox.Show("Dealer details not found");
                Close();
                return;
            }
            //lblDealerName.Text = dealer.Name;
            txtDealerName.Text = dealer.Name;

            if (BILL_ID != 0)
            {
                dealerBill = SharedRepo.DealerBillRepo.GetByID(BILL_ID);
                dtBillEntryDate.Value = DateHelper.GetDateObject(dealerBill.EntryDate);
                // lblEntyDate.Text = bill.EntryDate.ToString();
                dtBillDate.Value = DateHelper.GetDateObject(dealerBill.BillDate);
                numBillAmount.Value = dealerBill.TotalAmount;
                txtRemarks.Text = dealerBill.Remarks;
            }
            else
            {
                dealerBill = new DealerBill();
                dtBillEntryDate.Value = DateHelper.GetTodayDateObject();
                //lblEntyDate.Text = DateHelper.GetTodayDateString();
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
