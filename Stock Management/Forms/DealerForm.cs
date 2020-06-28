using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerForm : BaseForm
    {
        Dealer dealer;
        public int DealerId;
        public DealerForm()
        {
            InitializeComponent();
        }
        private void DealerForm_Load(object sender, EventArgs e)
        {
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
            if (DealerId != 0)
            {
                dealer = SharedRepo.DealerRepo.GetByID(DealerId);
                txtDealerName.Text = dealer.Name;
                txtAddress.Text = dealer.Address;
                txtMobile.Text = dealer.Mobile;
                txtEmail.Text = dealer.Email;
                txtRemarks.Text = dealer.Remarks;
            }
            else
            {
                dealer = new Dealer();
            }
        }

        private void SaveDealer()
        {
            dealer.Name = txtDealerName.Text;
            dealer.Address = txtAddress.Text;
            dealer.Mobile = txtMobile.Text;
            dealer.Email = txtEmail.Text;
            dealer.Remarks = txtRemarks.Text;
            dealer.ValidateDealer();
            if (dealer.EntityState.State == ValidationState.SUCCESS)
            {
                SharedRepo.DealerRepo.Save(dealer);
                Close();
            }
        }
    }
}
