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
            dgvDealerList.AutoGenerateColumns = false;
            ColDealerShowLink.UseColumnTextForLinkValue = true; // To show "Details" text on button

            dgvBillList.AutoGenerateColumns = false;
            ColBillShowLink.UseColumnTextForLinkValue = true;
            ColShowBillDetails.UseColumnTextForLinkValue = true;
            LoadDealerList();

            EnableAddBillButton();// initially no dealer is selected, so button should be disabled
        }

        private void btnAddDealer_Click(object sender, EventArgs e)
        {
            DealerForm dealerForm = new DealerForm();
            dealerForm.DealerId = 0;
            ShowFormAsDialog(this, dealerForm);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();
            billForm.DealerId = selectedDealer.Id;
            billForm.BillId = 0;
            ShowFormAsDialog(this, billForm);
        }

        private void dgvDealerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDealer = ((Dealer)dgvDealerList.Rows[e.RowIndex].DataBoundItem);
            //Session.DealerId = selectedDealer.Id;
            //Session.DealerName = selectedDealer.Name;

            DealerForm dealerForm = new DealerForm();
            dealerForm.DealerId = selectedDealer.Id;
            if (GetSelectedCellText(dgvDealerList, e) == "Details")
            {
                ShowFormAsDialog(this, dealerForm);
            }
            else
            {
                LoadBillList();
            }

            EnableAddBillButton();
        }
        private void dgvBillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBillId = ((Bill)dgvBillList.Rows[e.RowIndex].DataBoundItem).Id;

            if (GetSelectedCellText(dgvBillList, e) == "Details")
            {
                BillForm billForm = new BillForm();
                billForm.DealerId = selectedDealer.Id;
                billForm.BillId = selectedBillId;
                ShowFormAsDialog(this, billForm);
            }
            else if (GetSelectedCellText(dgvBillList, e) == "Add Breakups")
            {
                BillDetailListForm billDetailListForm = new BillDetailListForm();
                billDetailListForm.BillId = selectedBillId;
                ShowFormAsMDIChild(ParentForm, billDetailListForm);
            }
        }


        internal void LoadDealerList()
        {
            dealerList = Session.DealerRepo.GetDealerList(); // dealerRepo.GetDealerList();
            dgvDealerList.DataSource = dealerList;
        }

        internal void LoadBillList()
        {
            lblDealerName.Text = selectedDealer.Name;
            billList = Session.BillRepo.GetBillList(selectedDealer.Id);
            dgvBillList.DataSource = billList;
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


    }
}
