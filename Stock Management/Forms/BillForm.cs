using StockEntity.Entity;
using StockEntity.Helper;
using StockEntity.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillForm : Form
    {
        BillRepository billRepo = new BillRepository();
        DealerRepository dealerRepo = new DealerRepository();
        public Form CallerForm { get; set; }
        public Bill Bill = new Bill();
        public Dealer Dealer = new Dealer();

        public BillForm()
        {
            InitializeComponent();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            EditBill();
        }

        private void BillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm.Name == "BillListForm")
            {
                DealerListForm dealerForm = (DealerListForm)CallerForm;
                dealerForm.LoadBillList();
            }
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            SaveBill();
        }

        private void EditBill()
        {
            if (Dealer.Id == 0)
            {
                MessageBox.Show("Dealer ID not found");
            }
            else
            {
                Dealer = dealerRepo.GetByID(Dealer.Id);
                if (Dealer == null)
                {
                    MessageBox.Show("Dealer details not found");
                }
                else
                {
                    lblDealerName.Text = Dealer.Name;
                    if (Bill.Id != 0)
                    {
                        Bill = billRepo.GetByID(Bill.Id);
                        lblEntyDate.Text = Bill.BillEntryDate.ToString();
                        dtBillDate.Value = Bill.BillDate;
                        txtTotalAmount.Text = Convert.ToString(Bill.TotalAmount);
                        txtRemarks.Text = Bill.Remarks;
                    }
                    else
                    {
                        lblEntyDate.Text = new DateTime().ToString();
                    }
                }
            }
        }

        private void SaveBill()
        {
            float totalAmout;
            Bill.DealerId = Dealer.Id;
            Bill.BillEntryDate = new DateTime();
            Bill.BillDate = dtBillDate.Value;
            if (float.TryParse(txtTotalAmount.Text, out totalAmout))
            {
                Bill.TotalAmount = totalAmout;
            }
            Bill.Remarks = txtRemarks.Text;
            if (Bill.EntityState.State == ValidationState.SUCCESS)
            {
                billRepo.Add(Bill);
                Close();
            }
        }
    }
}
