using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerListForm : BaseForm
    {
        List<Dealer> dealerList;
        List<Bill> billList;
        Dealer selectedDealer;
        // Bill selectedBill;
        int selectedBillId;

        public DealerListForm()
        {
            InitializeComponent();
            this.EnumerateChildren();

            //dgvDealerList.AutoGenerateColumns = false;
            //dgvDealerList.ClearSelection();
            //ColDealerShowLink.UseColumnTextForLinkValue = true; // To show "Details" text on button

            //dgvBillList.AutoGenerateColumns = false;
            //dgvBillList.ClearSelection();
            //ColBillShowLink.UseColumnTextForLinkValue = true;
            //ColShowBillBreakups.UseColumnTextForLinkValue = true;
            //LoadDealerList();

            //EnableAddBillButton();// initially no dealer is selected, so button should be disabled
        }

        private void btnAddDealer_Click(object sender, EventArgs e)
        {
            DealerForm dealerForm = new DealerForm();
            dealerForm.DealerId = 0;
            ShowFormAsFixedDialog(this, dealerForm);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();
            billForm.DealerId = selectedDealer.Id;
            billForm.BillId = 0;
            ShowFormAsFixedDialog(this, billForm);
        }

        private void dgvDealerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            selectedDealer = ((Dealer)dgvDealerList.Rows[e.RowIndex].DataBoundItem);

            DealerForm dealerForm = new DealerForm();
            dealerForm.DealerId = selectedDealer.Id;
            if (GetSelectedCellText(dgvDealerList, e) == "Details")
            {
                ShowFormAsFixedDialog(this, dealerForm);
            }
            else
            {
                LoadBillList();
            }

            EnableAddBillButton();
        }
        private void dgvBillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            selectedBillId = ((Bill)dgvBillList.Rows[e.RowIndex].DataBoundItem).Id;

            if (GetSelectedCellText(dgvBillList, e) == "Details")
            {
                BillForm billForm = new BillForm();
                billForm.DealerId = selectedDealer.Id;
                billForm.BillId = selectedBillId;
                ShowFormAsFixedDialog(this, billForm);
            }
            else if (GetSelectedCellText(dgvBillList, e) == "Add Breakups")
            {
                BillBreakupListForm billBreakupForm = new BillBreakupListForm();
                billBreakupForm.BillId = selectedBillId;
                ShowFormResizableAsDialog(this, billBreakupForm);
            }
        }


        internal void LoadDealerList()
        {
            dealerList = SharedRepo.DealerRepo.GetDealerList(); // dealerRepo.GetDealerList();
            dgvDealerList.DataSource = dealerList;
            dgvDealerList.ClearSelection();
        }

        internal void LoadBillList()
        {
            txtDealerName.Text = selectedDealer.Name;
            billList = SharedRepo.BillRepo.GetBillList(selectedDealer.Id);
            dgvBillList.DataSource = billList;
            dgvBillList.ClearSelection();
        }

        public void EnableAddBillButton()
        {
            if (selectedDealer == null || selectedDealer.Id == 0)
            {
                btnAddBill.Enabled = false;
            }
            else
            {
                btnAddBill.Enabled = true;
            }
        }

        private void DealerListForm_Shown(object sender, EventArgs e)
        {
            dgvDealerList.AutoGenerateColumns = false;
            ColDealerShowLink.UseColumnTextForLinkValue = true; // To show "Details" text on button

            dgvBillList.AutoGenerateColumns = false;
            ColBillShowLink.UseColumnTextForLinkValue = true;
            ColShowBillBreakups.UseColumnTextForLinkValue = true;
            LoadDealerList();

            EnableAddBillButton();// initially no dealer is selected, so button should be disabled
        }
    }
}
