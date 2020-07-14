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
                Text = "Dealer Bill List";
                btnAddBill.Text = "Add Dealer Bill";
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                Text = "Customer Bill List";
                btnAddBill.Text = "Add Customer Bill";
                btnAddBill.Visible = false;
                ColBillShowLink.Visible = false;
            }
            else
            {
                Text = "Unknown";
                return;
            }

            SetFormBehaviour();

            dgvBillList.AutoGenerateColumns = false;
            ColBillShowLink.UseColumnTextForLinkValue = true;
            ColShowBillBreakups.UseColumnTextForLinkValue = true;

            LoadBillList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                OpenDealerBillForm(0);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            OpenDealerBillForm(0);
        }

        private void dgvBillList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            int selectedBillId = ((Bill)dgvBillList.Rows[e.RowIndex].DataBoundItem).Id;
            if (PERSON_TYPE == Person.DEALER)
            {
                if (GetSelectedCellText(dgvBillList, e) == "Details")
                {
                    OpenDealerBillForm(selectedBillId);
                    //DealerBillForm billForm = new DealerBillForm();
                    //billForm.DealerId = PERSON_ID;
                    //billForm.BILL_ID = selectedBillId;
                    //ShowFormAsFixedDialog(this, billForm);
                }
                else if (GetSelectedCellText(dgvBillList, e) == "Breakups")
                {
                    DealerBillBreakupListForm billBreakupForm = new DealerBillBreakupListForm();
                    billBreakupForm.DEALER_BILL_ID = selectedBillId;
                    ShowFormResizableAsDialog(this, billBreakupForm);
                }
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                if (GetSelectedCellText(dgvBillList, e) == "Details")
                {
                    CustomerBillBreakupListForm customerBillBreakupListForm = new CustomerBillBreakupListForm();
                    customerBillBreakupListForm.CUSTOMER_BILL_ID = selectedBillId;
                    ShowFormResizableAsDialog(this, customerBillBreakupListForm);
                }
            }
        }

        internal void LoadBillList()
        {
            if (PERSON_TYPE == Person.DEALER)
            {
                Dealer dealer = SharedRepo.DBRepo.GetDealerByID(PERSON_ID);
                if (dealer == null)
                {
                    MessageBox.Show("Dealer not found");
                    return;
                }
                txtPersonName.Text = dealer.Name;
                List<DealerBill> billList = SharedRepo.DBRepo.GetDealerBillList(PERSON_ID);
                dgvBillList.DataSource = billList;
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                Customer customer = SharedRepo.DBRepo.GetCustomerByID(PERSON_ID);
                if (customer == null)
                {
                    MessageBox.Show("Dealer not found");
                    return;
                }
                txtPersonName.Text = customer.Name;
                List<CustomerBill> billList = SharedRepo.DBRepo.GetCustomerBillList(PERSON_ID);
                dgvBillList.DataSource = billList;
            }
            dgvBillList.ClearSelection();
        }

        public void SetFormBehaviour()
        {
            //if (PERSON_TYPE == Person.CUSTOMER)
            //{
            //    btnAddBill.Visible = false;
            //    btnAddBill.Enabled = false;
            //    return;
            //}
        }

        private void OpenDealerBillForm(int billId)
        {
            DealerBillForm billForm = new DealerBillForm();
            billForm.DealerId = PERSON_ID;
            billForm.BILL_ID = billId;
            ShowFormAsFixedDialog(this, billForm);
        }

    }
}
