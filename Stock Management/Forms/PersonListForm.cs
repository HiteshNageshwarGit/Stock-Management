using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class PersonListForm : BaseForm
    {
        public int PERSON_TYPE { get; set; } // Can be Dealer or Customer
        public PersonListForm()
        {
            InitializeComponent();
            dgvDealerList.AutoGenerateColumns = false;

        }

        private void PersonListForm_Load(object sender, EventArgs e)
        {
            if (PERSON_TYPE == Person.DEALER)
            {
                Text = "Dealer List";
                lblSearchPerson.Text = "Search Dealer";
                btnAddPerson.Text = "Add Dealer";
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                Text = "Customer List";
                lblSearchPerson.Text = "Search Customer";
                btnAddPerson.Text = "Add Customer";
            }
            else
            {
                Text = "Unknown";
                lblSearchPerson.Text = "Search";
                btnAddPerson.Text = "Add";
                return; // no further execution
            }
            if (CallerForm != null && CallerForm.Name != null && CallerForm.Name == "CustomerBillBreakListForm")
            {
                ColSelectLink.Visible = true;
            }
            else
            {
                ColSelectLink.Visible = false; ;
            }

            LoadPersonList();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.PERSON_TYPE = PERSON_TYPE;
            personForm.PERSON_ID = 0;
            ShowFormAsFixedDialog(this, personForm);
        }

        private void dgvDealerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            if (GetSelectedCellText(dgvDealerList, e) == "Details")
            {
                PersonForm dealerForm = new PersonForm();
                dealerForm.PERSON_TYPE = PERSON_TYPE;
                dealerForm.PERSON_ID = ((Person)dgvDealerList.Rows[e.RowIndex].DataBoundItem).Id;
                ShowFormAsFixedDialog(this, dealerForm);
            }
            else if (GetSelectedCellText(dgvDealerList, e) == "Bills")
            {
                BillListForm billListForm = new BillListForm();
                billListForm.PERSON_TYPE = PERSON_TYPE;
                billListForm.PERSON_ID = ((Person)dgvDealerList.Rows[e.RowIndex].DataBoundItem).Id;
                ShowFormResizableAsDialog(this, billListForm);
            }
            else if (GetSelectedCellText(dgvDealerList, e) == "Select")
            {
                if (CallerForm != null && CallerForm.Name != null && CallerForm.Name == "CustomerBillBreakListForm")
                {
                    CustomerBillBreakListForm customerBillBreakListForm = (CustomerBillBreakListForm)CallerForm;
                    Person person = (Person)dgvDealerList.Rows[e.RowIndex].DataBoundItem;
                    customerBillBreakListForm.OnCustomerNameSelected(person.Id, person.Name);
                    Close();
                }
            }
        }

        private void PersonListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null || CallerForm.Name == null)
            {
                return;
            }
            else if (CallerForm.Name == "ProductSellForm")
            {

            }
        }

        internal void LoadPersonList()
        {
            if (PERSON_TYPE == Person.DEALER)
            {
                List<Dealer> dealerList = SharedRepo.DBRepo.GetDealerList();
                dgvDealerList.DataSource = dealerList;
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                List<Customer> dealerList = SharedRepo.DBRepo.GetCustomerList();
                dgvDealerList.DataSource = dealerList;
            }
            dgvDealerList.ClearSelection();
        }
    }
}
