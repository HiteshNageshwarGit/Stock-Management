using StockEntity.Entity;
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
    public partial class DealerListForm : Form
    {
        DealerRepository dealerRepo = new DealerRepository();
        BillRepository billRepo = new BillRepository();
        List<Dealer> dealerList;
        List<Bill> billList;
        public DealerListForm()
        {
            InitializeComponent();
            dgvDealerList.AutoGenerateColumns = false;
            ColMore.UseColumnTextForLinkValue = true; // To show "Details" text on button
            ColBills.UseColumnTextForLinkValue = true; // To show "Bills" text on button
            LoadDealerList();
        }

        private void btnAddDealer_Click(object sender, EventArgs e)
        {
            openDealerDetails(0);
        }

        private void dgvDealerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }

            int dealerId = ((Dealer)dgvDealerList.Rows[e.RowIndex].DataBoundItem).Id;
            if (dgvDealerList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "Details".ToLower())
            {
                openDealerDetails(dealerId);
            }
            else if (dgvDealerList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "Add Bill".ToLower())
            {
                opeBillDetails(dealerId);
            }
        }
        private void dgvBillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }
            int dealerId = ((Dealer)dgvDealerList.Rows[e.RowIndex].DataBoundItem).Id;
            if (dgvDealerList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "Add Breakups".ToLower())
            {
                //openDealerDetails(dealerId);
            }
        }

        internal void LoadDealerList()
        {
            dealerList = dealerRepo.GetDealerList();
            dgvDealerList.DataSource = dealerList;
        }

        internal void LoadBillList()
        {
            billList = billRepo.GetBillList();
            dgvBillList.DataSource = billList;
        }

        private void openDealerDetails(int dealerId)
        {
            //pnlForDealerDetails.Visible = true;
            DealerForm dealerForm = new DealerForm();
            dealerForm.callerForm = this;
            dealerForm.dealer.Id = dealerId;
            //dealerForm.TopLevel = false;
            //pnlForDealerDetails.Controls.Add(dealerForm);
            //dealerForm.FormBorderStyle = FormBorderStyle.None;
            //dealerForm.Dock = DockStyle.Fill;
            dealerForm.MdiParent = this.ParentForm;
            dealerForm.MaximizeBox = false;
            dealerForm.MinimizeBox = false;
            dealerForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            dealerForm.WindowState = FormWindowState.Normal;
            dealerForm.Show();
        }

        private void opeBillDetails(int dealerId)
        {
            //pnlForDealerDetails.Visible = true;
            BillForm dealerForm = new BillForm();
            dealerForm.CallerForm = this;
            dealerForm.Dealer.Id = dealerId;
            dealerForm.MdiParent = ParentForm;
            dealerForm.MaximizeBox = false;
            dealerForm.MinimizeBox = false;
            dealerForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            dealerForm.WindowState = FormWindowState.Normal;
            dealerForm.Show();
        }

        private void OpenDealersBills()
        {

        }


    }
}
