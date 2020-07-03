using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerForm : BaseForm
    {
        public int PERSON_TYPE { get; set; } // Can be Dealer or Customer
        public int PERSON_ID { get; set; } // Can be Dealer ID or Customer ID

        Person person;

        public DealerForm()
        {
            InitializeComponent();
        }

        private void DealerForm_Load(object sender, EventArgs e)
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
                btnSaveDealer.Enabled = false;
                return;
            }
            EditDealer();
        }

        private void DealerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (CallerForm.Name == "DealerListForm")
            {
                ((DealerListForm)CallerForm).LoadDealerList();
            }
        }
        private void btnSaveDealer_Click(object sender, EventArgs e)
        {
            SaveDealer();
        }

        private void EditDealer()
        {
            if (PERSON_ID != 0)
            {
                if (PERSON_TYPE == Person.DEALER)
                {
                    person = SharedRepo.DealerRepo.GetByID(PERSON_ID);
                }
                else if (PERSON_TYPE == Person.CUSTOMER)
                {
                    person = SharedRepo.CustomerRepo.GetByID(PERSON_ID);
                }

                txtDealerName.Text = person.Name;
                txtAddress.Text = person.Address;
                txtMobile.Text = person.Mobile;
                txtEmail.Text = person.Email;
                txtRemarks.Text = person.Remarks;
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

        private void SaveDealer()
        {
            person.Name = txtDealerName.Text;
            person.Address = txtAddress.Text;
            person.Mobile = txtMobile.Text;
            person.Email = txtEmail.Text;
            person.Remarks = txtRemarks.Text;
            person.Validate();
            if (person.EntityState.State != ValidationState.SUCCESS)
            {
                MessageBox.Show(person.EntityState.StateMessage, "Error");
                return;
            }

            if (PERSON_TYPE == Person.DEALER)
            {
                if (SharedRepo.DealerRepo.DoesDelaerNameExists((Dealer)person))
                {
                    MessageBox.Show("Dealer name already exists", "Error");
                    return;
                }
                SharedRepo.DealerRepo.Save((Dealer)person);
            }
            else
            {
                if (SharedRepo.CustomerRepo.DoesCustomerNameExists((Customer)person))
                {
                    MessageBox.Show("Dealer name already exists", "Error");
                    return;
                }
                SharedRepo.CustomerRepo.Save((Customer)person);
            }
            Close();
        }
    }
}
