﻿using Stock_Management.Shared;
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
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericFieldKeyPress(sender, e);
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
            else if (CallerForm.Name == "PersonListForm")
            {
                ((PersonListForm)CallerForm).LoadPersonList();
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
                    person = SharedRepo.DBRepo.GetDealerByID(PERSON_ID);
                }
                else if (PERSON_TYPE == Person.CUSTOMER)
                {
                    person = SharedRepo.DBRepo.GetCustomerByID(PERSON_ID);
                }

                txtDealerName.Text = person.Name;
                txtAddress.Text = person.Address;
                txtMobile.Text = person.Mobile;
                txtEmail.Text = person.Email;
                txtRemarks.Text = person.Remarks;

                if (person.Name.ToLower() == Person.DEFAULT_NAME.ToLower())
                {
                    txtDealerName.Enabled = false;
                    btnSaveDealer.Enabled = false;
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

        private void SaveDealer()
        {
            person.ResetValidationError();
            person.Name = txtDealerName.Text.Trim();
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
            Close();
        }


    }
}
