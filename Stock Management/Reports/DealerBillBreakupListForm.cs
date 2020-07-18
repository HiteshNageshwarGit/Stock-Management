using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillBreakupListForm : BaseForm
    {
        private int _dealetBillId { get; set; }
        public DealerBillBreakupListForm(int dealetBillId)
        {
            InitializeComponent();
            _dealetBillId = dealetBillId;
            dgvBillBreakupList.AutoGenerateColumns = false;
            ColDetail.UseColumnTextForLinkValue = true;
            SetDataGridViewProperties(dgvBillBreakupList);
        }

        private void BillBreakupListForm_Load(object sender, EventArgs e)
        {
            LoadBillBreakupList(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void LoadBillBreakupList(bool reopenBillBreakupForm)
        {
            ShowFormInGroupBox(this, grpBoxBrakupCount, new DealerBillBreakupCountForm(_dealetBillId));
            List<DealerBillBreakup> BillBreakupsList = SharedRepo.DBRepo.GetDealerBillBreakupList(_dealetBillId);
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
            DealerBillBreakupForm BillBreakupForm = new DealerBillBreakupForm(_dealetBillId, dealerBillBreakupId);
            ShowFormAsFixedDialog(this, BillBreakupForm);
        }

    }
}
