using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillForm : BaseForm
    {
        public Bill bill;
        Dealer dealer;
        public int DealerId;
        public int BillId;
        public BillForm()
        {
            InitializeComponent();
            dtBillDate.CustomFormat = DateHelper.DATE_FORMAT;
            dtBillEntryDate.CustomFormat = DateHelper.DATE_FORMAT;
            this.EnumerateChildren();
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

            if (BillId != 0)
            {
                bill = SharedRepo.BillRepo.GetByID(BillId);
                dtBillEntryDate.Value = DateHelper.GetDateObject(bill.EntryDate);
                // lblEntyDate.Text = bill.EntryDate.ToString();
                dtBillDate.Value = DateHelper.GetDateObject(bill.BillDate);
                numBillAmount.Value = bill.TotalAmount;
                txtRemarks.Text = bill.Remarks;
            }
            else
            {
                bill = new Bill();
                dtBillEntryDate.Value = DateHelper.GetTodayDateObject();
                //lblEntyDate.Text = DateHelper.GetTodayDateString();
            }
        }

        private void SaveBill()
        {
            bill.DealerId = dealer.Id;
            bill.EntryDate = DateHelper.GetDateString(dtBillEntryDate.Value); //lblEntyDate.Text;
            bill.BillDate = DateHelper.GetDateString(dtBillDate.Value);
            bill.TotalAmount = numBillAmount.Value;
            bill.Remarks = txtRemarks.Text;
            if (bill.EntityState.State == ValidationState.SUCCESS)
            {
                SharedRepo.BillRepo.Save(bill);
                Close();
            }
        }


    }
}
