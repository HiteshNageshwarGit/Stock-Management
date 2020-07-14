using Stock_Management.Shared;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class LoginForm : BaseForm
    {
        int loginAttempcount;
        bool isLoginSucceeded;
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ProcessLogin();
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                LoginAsNonAdmin();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProcessLogin();
        }

        private void btnNoAdmin_Click(object sender, EventArgs e)
        {
            LoginAsNonAdmin();
        }

        private void ProcessLogin()
        {
            isLoginSucceeded = false;
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("User Name or Password can not be blank");
                return;
            }
            else
            {
                if (txtUserName.Text == SharedRepo.DBRepo.GetKeyValue(SharedRepo.AdminUser).Value
                    && txtPassword.Text == SharedRepo.DBRepo.GetKeyValue(SharedRepo.AdminPassword).Value)
                {
                    isLoginSucceeded = true;
                    SharedRepo.UserRole = SharedRepo.AdminUser;
                }
                else
                {
                    isLoginSucceeded = false;
                    if (loginAttempcount > 3)
                    {
                        MessageBox.Show("Reached to maximum attempts");
                    }
                    else
                    {
                        loginAttempcount++;
                        MessageBox.Show("Incorrect user name or password");
                        return;
                    }
                }

                if (CallerForm != null && CallerForm.Name != null && CallerForm.Name == "MainForm")
                {
                    MainForm mainForm = (MainForm)CallerForm;
                    mainForm.On_User_Login(isLoginSucceeded);
                }
                else
                {
                    MessageBox.Show("Could not continue from here");
                }
                Close();
            }
        }

        private void LoginAsNonAdmin()
        {
            isLoginSucceeded = true;
            SharedRepo.UserRole = SharedRepo.GeneralUser;
            MainForm mainForm = (MainForm)CallerForm;
            mainForm.On_User_Login(isLoginSucceeded);
            Close();
        }
    }
}
