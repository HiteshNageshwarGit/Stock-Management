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
            dealer = Session.DealerRepo.GetByID(DealerId);
            if (dealer == null)
            {
                MessageBox.Show("Dealer details not found");
                Close();
                return;
            }
            lblDealerName.Text = dealer.Name;

            if (BillId != 0)
            {
                bill = Session.BillRepo.GetByID(BillId);
                lblEntyDate.Text = bill.EntryDate.ToString();
                dtBillDate.Value = DateHelper.GetDateObject(bill.BillDate);
                txtTotalAmount.Text = Convert.ToString(bill.TotalAmount);
                txtRemarks.Text = bill.Remarks;
            }
            else
            {
                bill = new Bill();
                lblEntyDate.Text = DateHelper.GetTodayDateString();
            }
        }

        private void SaveBill()
        {
            float totalAmout;
            bill.DealerId = dealer.Id;
            bill.EntryDate = lblEntyDate.Text;
            bill.BillDate = DateHelper.GetDateString(dtBillDate.Value);
            if (float.TryParse(txtTotalAmount.Text, out totalAmout))
            {
                bill.TotalAmount = totalAmout;
            }
            bill.Remarks = txtRemarks.Text;
            if (bill.EntityState.State == ValidationState.SUCCESS)
            {
                Session.BillRepo.Save(bill);
                Close();
            }
        }
    }
}
