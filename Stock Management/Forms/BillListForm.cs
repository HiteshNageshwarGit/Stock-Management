using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillListForm : BaseForm
    {
        public int PERSON_TYPE { get; set; } // Can be Dealer or Customer
        public int PERSON_ID { get; set; } // Can be Dealer ID or Customer ID
        public BillListForm()
        {
            InitializeComponent();
        }

        private void BillListForm_Load(object sender, EventArgs e)
        {
            if (PERSON_TYPE == Person.DEALER)
            {
                Text = "Dealer";
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                Text = "Customer";
                ColBillShowLink.Visible = false;
                ColShowBillBreakups.Visible = false;
            }
            else
            {
                Text = "Unknown";
                return;
            }

            EnableAddBillButton();

            dgvBillList.AutoGenerateColumns = false;
            ColBillShowLink.UseColumnTextForLinkValue = true;
            ColShowBillBreakups.UseColumnTextForLinkValue = true;

            LoadBillList();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            DealerBillForm billForm = new DealerBillForm();
            billForm.DealerId = PERSON_ID;
            billForm.BILL_ID = 0;
            ShowFormAsFixedDialog(this, billForm);
        }

        private void dgvBillList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            if (PERSON_TYPE == Person.DEALER)
            {
                int selectedBillId = ((Bill)dgvBillList.Rows[e.RowIndex].DataBoundItem).Id;
                if (GetSelectedCellText(dgvBillList, e) == "Details")
                {
                    DealerBillForm billForm = new DealerBillForm();
                    billForm.DealerId = PERSON_ID;
                    billForm.BILL_ID = selectedBillId;
                    ShowFormAsFixedDialog(this, billForm);
                }
                else if (GetSelectedCellText(dgvBillList, e) == "Add Breakups")
                {
                    DealerBillBreakupListForm billBreakupForm = new DealerBillBreakupListForm();
                    billBreakupForm.DEALER_BILL_ID = selectedBillId;
                    ShowFormResizableAsDialog(this, billBreakupForm);
                }
            }
        }

        internal void LoadBillList()
        {
            //txtDealerName.Text = selectedePerson.Name;
            if (PERSON_TYPE == Person.DEALER)
            {
                List<DealerBill> billList = SharedRepo.DealerBillRepo.GetBillList(PERSON_ID);
                dgvBillList.DataSource = billList;
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                List<CustomerBill> billList = SharedRepo.CustomerRepo.GetCustomerBillList(PERSON_ID);
                dgvBillList.DataSource = billList;
            }
            dgvBillList.ClearSelection();
        }

        public void EnableAddBillButton()
        {
            if (PERSON_TYPE == Person.CUSTOMER)
            {
                btnAddBill.Visible = false;
                btnAddBill.Enabled = false;
                return;
            }
        }


    }
}
