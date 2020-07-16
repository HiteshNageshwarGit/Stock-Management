using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
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
            LoadBillBreakupList(false);
        }

        private void BillBreakupListForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void LoadBillBreakupList(bool reopenBillBreakupForm)
        {
            ShowFormInGroupBox(this, grpBoxBrakupCount, new DealerBillBreakupCountForm(DEALER_BILL_ID));
            List<DealerBillBreakup> BillBreakupsList = SharedRepo.DBRepo.GetDealerBillBreakupList(DEALER_BILL_ID);
            dgvBillBreakupList.DataSource = BillBreakupsList;
            dgvBillBreakupList.ClearSelection();

            if (reopenBillBreakupForm)
            {
                OpenBillBreakupForm(0);
            }
        }

        private void btnAddBillBreakup_Click(object sender, EventArgs e)
        {
            OpenBillBreakupForm(0);
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
                OpenBillBreakupForm(dealerBillBreakup.Id);
            }
        }

        private void OpenBillBreakupForm(int dealerBillBreakupId)
        {
            DealerBillBreakupForm BillBreakupForm = new DealerBillBreakupForm();
            BillBreakupForm.BillId = DEALER_BILL_ID;
            BillBreakupForm.BillBreakupId = dealerBillBreakupId;
            ShowFormAsFixedDialog(this, BillBreakupForm);
        }

    }
}
