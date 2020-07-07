using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillBreakupListForm : BaseForm
    {
        public int DEALER_BILL_ID { get; set; }
        public DealerBillBreakupListForm()
        {
            InitializeComponent();
            dgvBillBreakupList.AutoGenerateColumns = false;
            ColDetail.UseColumnTextForLinkValue = true;
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
            DealerBill bill = SharedRepo.DealerBillRepo.GetByID(DEALER_BILL_ID);
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
            txtTotalBreakupAmount.Text = bill.DealerBillBreakupList.Sum(x => x.TotalAmount).ToString();
            txtRemarks.Text = bill.Remarks;

            List<DealerBillBreakup> BillBreakupsList = SharedRepo.DealerBillBreakupRepo.GetBillBreakupList(DEALER_BILL_ID);
            dgvBillBreakupList.DataSource = BillBreakupsList;
            dgvBillBreakupList.ClearSelection();
        }

        private void btnAddBillBreakup_Click(object sender, EventArgs e)
        {
            DealerBillBreakupForm BillBreakupForm = new DealerBillBreakupForm();
            BillBreakupForm.BillId = DEALER_BILL_ID;
            BillBreakupForm.BillBreakupId = 0;
            ShowFormAsFixedDialog(this, BillBreakupForm);
        }

        private void dgvBillBreakupList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }            

            if (GetSelectedCellText(dgvBillBreakupList, e) == "Details")
            {
                DealerBillBreakup dealerBillBreakup = ((DealerBillBreakup)dgvBillBreakupList.Rows[e.RowIndex].DataBoundItem);
                DealerBillBreakupForm BillBreakupForm = new DealerBillBreakupForm();
                BillBreakupForm.BillId = DEALER_BILL_ID;
                BillBreakupForm.BillBreakupId = dealerBillBreakup.Id;
                ShowFormAsFixedDialog(this, BillBreakupForm);
            }
        }
    }
}
