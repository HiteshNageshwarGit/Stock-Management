using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerListForm : BaseForm
    {
        public int PERSON_TYPE { get; set; } // Can be Dealer or Customer
        private Person selectedePerson;
        private int selectedBillId;

        public DealerListForm()
        {
            InitializeComponent();
            //this.EnumerateChildren();
        }

        private void DealerListForm_Load(object sender, EventArgs e)
        {
            if (PERSON_TYPE == Person.DEALER)
            {
                Text = "Dealer";
                btnAddDealer.Text = "Add Dealer";
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                Text = "Customer";
                btnAddDealer.Text = "Add Customer";
                EnableAddBillButton();
            }
            else
            {
                Text = "Unknown";
                btnAddDealer.Text = "Add";
                EnableFormControls(false);
                return;
            }
        }

        private void btnAddDealer_Click(object sender, EventArgs e)
        {
            DealerForm dealerForm = new DealerForm();
            dealerForm.PERSON_ID = 0;
            dealerForm.PERSON_TYPE = PERSON_TYPE;
            ShowFormAsFixedDialog(this, dealerForm);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();

            billForm.DealerId = selectedePerson.Id;
            billForm.BILL_ID = 0;
            ShowFormAsFixedDialog(this, billForm);
        }

        private void dgvDealerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            selectedePerson = ((Person)dgvDealerList.Rows[e.RowIndex].DataBoundItem);

            DealerForm dealerForm = new DealerForm();
            dealerForm.PERSON_TYPE = PERSON_TYPE;
            dealerForm.PERSON_ID = selectedePerson.Id;
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
                billForm.DealerId = selectedePerson.Id;
                billForm.BILL_ID = selectedBillId;
                ShowFormAsFixedDialog(this, billForm);
            }
            else if (GetSelectedCellText(dgvBillList, e) == "Add Breakups")
            {
                BillBreakupListForm billBreakupForm = new BillBreakupListForm();
                billBreakupForm.DEALER_BILL_ID = selectedBillId;
                ShowFormResizableAsDialog(this, billBreakupForm);
            }
        }


        internal void LoadDealerList()
        {
            if (PERSON_TYPE == Person.DEALER)
            {
                List<Dealer> dealerList = SharedRepo.DealerRepo.GetDealerList();
                dgvDealerList.DataSource = dealerList;
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                List<Customer> dealerList = SharedRepo.CustomerRepo.GetCustomerList();
                dgvDealerList.DataSource = dealerList;
            }
            dgvDealerList.ClearSelection();
        }

        internal void LoadBillList()
        {
            txtDealerName.Text = selectedePerson.Name;
            if (PERSON_TYPE == Person.DEALER)
            {
                List<DealerBill> billList = SharedRepo.DealerBillRepo.GetBillList(selectedePerson.Id);
                dgvBillList.DataSource = billList;
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {

            }
            dgvBillList.ClearSelection();
        }

        public void EnableAddBillButton()
        {
            if (PERSON_TYPE == Person.CUSTOMER)
            {
                btnAddBill.Enabled = false;
                return;
            }

            if (selectedePerson == null || selectedePerson.Id == 0)
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

        private void EnableFormControls(bool enable)
        {
            btnAddBill.Enabled = enable;
            btnAddBill.Enabled = enable;
            dgvDealerList.Enabled = enable;
            dgvBillList.Enabled = enable;
        }


    }
}
