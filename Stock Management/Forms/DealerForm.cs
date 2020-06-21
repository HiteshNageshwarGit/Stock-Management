using StockEntity.Entity;
using StockEntity.Helper;
using StockEntity.Repository;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerForm : Form
    {
        public Form callerForm { get; set; }
        public Dealer dealer = new Dealer();
        //public int DealerId { get; set; }
        DealerRepository dealerRepo = new DealerRepository();
     
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
            if (callerForm.Name == "DealerListForm")
            {
                DealerListForm dealerForm = (DealerListForm)callerForm;
                dealerForm.LoadDealerList();
            
            }
        }
        private void btnSaveDealer_Click(object sender, EventArgs e)
        {
            SaveDealer();
        }

        private void EditDealer()
        {
            if (dealer.Id != 0)
            {
                dealer = dealerRepo.GetByID(dealer.Id);
                this.txtDealerName.Text = dealer.Name;
                this.txtAddress.Text = dealer.Address;
                this.txtMobile.Text = dealer.Mobile;
                this.txtEmail.Text = dealer.Email;
                this.txtRemarks.Text = dealer.Remarks;
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
                dealerRepo.Save(dealer);
                this.Close();
            }
        }       
    }
}
