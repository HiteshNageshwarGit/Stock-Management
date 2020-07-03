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

        DealerListForm dealerListForm;
        ProductListForm productListForm;
        SellForm sellForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeApplicatoin()
        {
            try
            {
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
                    // If  file backup is success then only delete old files 
                    KeyValue keyValue = SharedRepo.keyValueRepo.GetKeyValue(SharedRepo.DBBackupDir);
                    if (keyValue != null)
                    {
                        if (DBFileHelper.BackupDBFile(AppDomain.CurrentDomain.BaseDirectory, keyValue.Value))
                        {
                            DBFileHelper.DeleteOldBackupFiles(keyValue.Value);
                        }
                        else
                        {
                            MessageBox.Show("Taking DB backup failed to " + SharedRepo.keyValueRepo.GetKeyValue(SharedRepo.DBBackupDir).Value);
                        }
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
            //CloseMDIChildForms(this);
            //if (sellForm == null || sellForm.IsDisposed)
            //{
            //    sellForm = new SellForm();
            //}
            //ShowFormAsMDIChild(this, sellForm);
            //SharedRepo.InsertDummyData();
        }

        private void dealerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMDIChildForms(this);
            if (dealerListForm == null || dealerListForm.IsDisposed)
            {
                dealerListForm = new DealerListForm();
            }
            dealerListForm.PERSON_TYPE = Person.DEALER;
            ShowFormAsMDIChild(this, dealerListForm);
        }
        private void menuCustomerList_Click(object sender, EventArgs e)
        {
            CloseMDIChildForms(this);
            if (dealerListForm == null || dealerListForm.IsDisposed)
            {
                dealerListForm = new DealerListForm();
            }
            dealerListForm.PERSON_TYPE = Person.CUSTOMER;
            ShowFormAsMDIChild(this, dealerListForm);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMDIChildForms(this);
            if (productListForm == null || productListForm.IsDisposed)
            {
                productListForm = new ProductListForm();
            }
            ShowFormAsMDIChild(this, productListForm);
        }

        private void menuSellProduct_Click(object sender, EventArgs e)
        {
            CloseMDIChildForms(this);
            if (sellForm == null || sellForm.IsDisposed)
            {
                sellForm = new SellForm();
            }
            ShowFormAsMDIChild(this, sellForm);
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

       
    }
}
