using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class PersonForm : BaseForm
    {
        public int PERSON_TYPE { get; set; } // Can be Dealer or Customer
        public int PERSON_ID { get; set; } // Can be Dealer ID or Customer ID

        Person person;

        public PersonForm()
        {
            InitializeComponent();
            PrepareTooltips(this);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SavePerson();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            ToTitleCase(txtName);
        }

        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            ToTitleCase(txtAddress);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericContyrolKeyPress(sender, e);
        }
        private void PersonForm_Load(object sender, EventArgs e)
        {
            Text = PERSON_ID == 0 ? "Add" : "Edit";
            if (PERSON_TYPE == Person.DEALER)
            {
                Text = Text + " " + "Dealer";
            }
            else if (PERSON_TYPE == Person.CUSTOMER)
            {
                Text = Text + " " + "Customer";
            }
            else
            {
                btnSavePerson.Enabled = false;
                return;
            }
            EditPerson();
        }

        private void PersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (CallerForm == null && CallerForm.Name !=null)
            //{
            //    return;
            //}
            //else if (CallerForm.Name == "PersonListForm")
            //{
            //    ((PersonListForm)CallerForm).LoadPersonList();
            //}
        }
        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            SavePerson();
        }

        private void EditPerson()
        {
            if (PERSON_ID != 0)
            {
                if (PERSON_TYPE == Person.DEALER)
                {
                    person = SharedRepo.DBRepo.GetDealerByID(PERSON_ID);
                }
                else if (PERSON_TYPE == Person.CUSTOMER)
                {
                    person = SharedRepo.DBRepo.GetCustomerByID(PERSON_ID);
                }

                txtName.Text = person.Name;
                txtAddress.Text = person.Address;
                txtMobile.Text = person.Mobile;
                txtEmail.Text = person.Email;
                txtRemarks.Text = person.Remarks;

                if (person.Name.ToLower() == Person.DEFAULT_NAME.ToLower())
                {
                    txtName.Enabled = false;
                    btnSavePerson.Enabled = false;
                }
            }
            else
            {
                if (PERSON_TYPE == Person.DEALER)
                {
                    person = new Dealer();
                }
                else
                {
                    person = new Customer();
                }
            }
        }

        private void SavePerson()
        {
            person.ResetValidationError();
            person.Name = txtName.Text.Trim();
            person.Address = txtAddress.Text.Trim();
            person.Mobile = txtMobile.Text.Trim();
            person.Email = txtEmail.Text.Trim();
            person.Remarks = txtRemarks.Text.Trim();

            person.Validate();
            if (person.EntityState.State != ValidationState.SUCCESS)
            {
                MessageBox.Show(person.EntityState.StateMessage, "Error");
                return;
            }

            if (PERSON_TYPE == Person.DEALER)
            {
                if (SharedRepo.DBRepo.DoesDealerNameExists((Dealer)person))
                {
                    MessageBox.Show("Dealer name already exists", "Error");
                    return;
                }
                SharedRepo.DBRepo.SaveDealer((Dealer)person);
            }
            else
            {
                if (SharedRepo.DBRepo.DoesCustomerNameExists((Customer)person))
                {
                    MessageBox.Show("Customer name already exists", "Error");
                    return;
                }
                SharedRepo.DBRepo.SaveCustomer((Customer)person);
            }

            if (CallerForm == null && CallerForm.Name != null)
            {
                return;
            }
            else if (CallerForm.Name == "PersonListForm")
            {
                ((PersonListForm)CallerForm).LoadPersonList();
            }

            Close();
        }


    }
}
