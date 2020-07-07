using Stock_Management.Forms;
using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class MainForm : BaseForm
    {
        int RetryCount = 0;
        //DealerListForm dealerListForm;
        PersonListForm personListForm;
        ProductListForm productListForm;
        CustomerCartForm sellForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeApplicatoin()
        {
            try
            {
                if (RetryCount > 10)
                {
                    MessageBox.Show("Applicatoin initialization failed");
                }

                RetryCount++;
                if (!DBFileHelper.IsDBFileAvailable(AppDomain.CurrentDomain.BaseDirectory))
                {
                    MessageBox.Show("Please check DB file in app folder and it is not in read only mode");
                    Close();
                }
                else if (!IsDBCompitable())
                {
                    MessageBox.Show("Current Database is not compitable, please update Database");
                }
                else if (string.IsNullOrWhiteSpace(SharedRepo.UserRole))
                {
                    LoginForm loginForm = new LoginForm();
                    ShowFormAsFixedDialog(this, loginForm);
                }
                else
                {

                    KeyValue keyValue = SharedRepo.keyValueRepo.GetKeyValue(SharedRepo.DBBackupDir);
                    if (keyValue == null)
                    {
                        MessageBox.Show("DB backup directory is not configured. Please configure it ");
                    }
                    else
                    {
                        if (DBFileHelper.BackupDBFile(AppDomain.CurrentDomain.BaseDirectory, keyValue.Value))
                        {
                            // If  file backup is success then only delete old files 
                            DBFileHelper.DeleteOldBackupFiles(keyValue.Value);
                        }
                        else
                        {
                            MessageBox.Show("Taking DB backup failed to " + SharedRepo.keyValueRepo.GetKeyValue(SharedRepo.DBBackupDir).Value);
                        }
                    }

                    // Check for Default Dealer/Customer.
                    if (!(SharedRepo.CustomerRepo.DoesDefaulCustomerNameExist() && SharedRepo.DealerRepo.DoesDefaulDealerNameExist()))
                    {
                        MessageBox.Show("Default dealer or default customer not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. \n " + ex.Message);
            }
        }

        internal void On_User_Login(bool isLoginSucceeded)
        {
            if (isLoginSucceeded)
            {
                ShowAdminRelatedMenuItems();
                InitializeApplicatoin();
            }
            else
            {
                Close();
            }
        }

        private void On_Menu_Selectoin_Change()
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            SharedRepo.InitializeSession();
            InitializeApplicatoin();
        }

        private void dealerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPersonListForm(Person.DEALER);
        }
        private void menuCustomerList_Click(object sender, EventArgs e)
        {
            OpenPersonListForm(Person.CUSTOMER);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CloseMDIChildForms(this);
            //if (productListForm == null || productListForm.IsDisposed)
            //{
            //    productListForm = new ProductListForm();
            //}
            //ShowFormAsMDIChild(this, productListForm);
            ShowFormResizableAsDialog(this, new ProductListForm());
        }

        private void menuSellProduct_Click(object sender, EventArgs e)
        {
            //CloseMDIChildForms(this);
            //if (sellForm == null || sellForm.IsDisposed)
            //{
            //    sellForm = new CustomerCart();
            //}
            //ShowFormAsMDIChild(this, sellForm);
            ShowFormResizableAsDialog(this, new CustomerCartForm());
        }

        private void ShowAdminRelatedMenuItems()
        {
            if (SharedRepo.UserRole == SharedRepo.AdminUser)
            {
                //menuAdmin.Visible = true;
                //menuLogin.Visible = false;
            }
            else
            {
                //menuAdmin.Visible = false;
                //menuLogin.Visible = true;
            }
        }

        private bool IsDBCompitable()
        {
            var ff = SharedRepo.ProductRepo.GetProductListForAdmin("");
            string compitableDBVersion = ConfigurationManager.AppSettings["CompitableDBVersions"];
            if (!string.IsNullOrWhiteSpace(compitableDBVersion))
            {
                string[] arr = compitableDBVersion.Split(',');
                if (arr.Length > 0)
                {
                    string dbVersion = SharedRepo.keyValueRepo.GetKeyValue(SharedRepo.DBVersion).Value;
                    if (dbVersion != null && dbVersion.Length > 0)
                    {
                        if (arr.Contains(dbVersion))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void OpenPersonListForm(int personType)
        {
            //CloseMDIChildForms(this);
            //if (personListForm == null || personListForm.IsDisposed)
            //{
            //    personListForm = new PersonListForm();
            //}
            //personListForm.PERSON_TYPE = personType;
            //ShowFormAsMDIChild(this, personListForm);

            personListForm = new PersonListForm();
            personListForm.PERSON_TYPE = personType;
            ShowFormResizableAsDialog(this, personListForm);
        }


    }
}
