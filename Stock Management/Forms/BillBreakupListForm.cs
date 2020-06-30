using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillBreakupListForm : BaseForm
    {
        List<BillBreakup> BillBreakupsList;
        public int BillId;
        public BillBreakupListForm()
        {
            InitializeComponent();
            dgvBillBreakupList.AutoGenerateColumns = false;
        }

        private void BillBreakupListForm_Load(object sender, EventArgs e)
        {
            LoadBillBreakupList();
        }

        private void BillBreakupListForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void LoadBillBreakupList()
        {
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

            BillBreakupsList = SharedRepo.BillBreakupRepo.GetBillBreakupList(BillId);
            dgvBillBreakupList.DataSource = BillBreakupsList;
            dgvBillBreakupList.ClearSelection();
        }

        private void btnAddBillBreakup_Click(object sender, EventArgs e)
        {
            BillBreakupForm BillBreakupForm = new BillBreakupForm();
            BillBreakupForm.BillId = BillId;
            BillBreakupForm.BillBreakupId = 0;
            ShowFormAsFixedDialog(this, BillBreakupForm);
        }

       
    }
}
