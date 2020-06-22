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
        int SelectedDealerId;
        public DealerListForm()
        {
            InitializeComponent();
            dgvDealerList.AutoGenerateColumns = false;
            ColDealerShowLink.UseColumnTextForLinkValue = true; // To show "Details" text on button

            dgvBillList.AutoGenerateColumns = false;
            ColBillShowLink.UseColumnTextForLinkValue = true;
            LoadDealerList();
        }

        private void btnAddDealer_Click(object sender, EventArgs e)
        {
            openDealerForm(0);
        }

        private void dgvDealerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int dealerId = ((Dealer)dgvDealerList.Rows[e.RowIndex].DataBoundItem).Id;
            SelectedDealerId = dealerId;
            lblDealerName.Text = ((Dealer)dgvDealerList.Rows[e.RowIndex].DataBoundItem).Name;
            LoadBillList(dealerId);

            if (e.ColumnIndex != -1 && dgvDealerList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "Details".ToLower())
            {                
                openDealerForm(dealerId);
            }
        }
        private void dgvBillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int billId = ((Dealer)dgvBillList.Rows[e.RowIndex].DataBoundItem).Id;
            if (e.ColumnIndex != -1 && dgvBillList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "Details".ToLower())
            {
                opeBillForm(SelectedDealerId, billId);
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {           
            opeBillForm(SelectedDealerId, 0);
        }

        internal void LoadDealerList()
        {
            dealerList = dealerRepo.GetDealerList();
            dgvDealerList.DataSource = dealerList;
        }

        internal void LoadBillList(int dealerId)
        {
            billList = billRepo.GetBillList(dealerId);
            dgvBillList.DataSource = billList;
        }

        private void openDealerForm(int dealerId)
        {
            DealerForm dealerForm = new DealerForm();
            dealerForm.callerForm = this;
            dealerForm.dealer.Id = dealerId;
            dealerForm.MdiParent = this.ParentForm;
            dealerForm.MaximizeBox = false;
            dealerForm.MinimizeBox = false;
            dealerForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            dealerForm.WindowState = FormWindowState.Normal;
            dealerForm.Show();
        }

        private void opeBillForm(int dealerId, int billId)
        {
            BillForm billForm = new BillForm();
            billForm.CallerForm = this;
            billForm.Dealer.Id = dealerId;
            billForm.Bill.Id = billId;
            billForm.Bill.DealerId = dealerId;
            billForm.MdiParent = ParentForm;
            billForm.MaximizeBox = false;
            billForm.MinimizeBox = false;
            billForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            billForm.WindowState = FormWindowState.Normal;
            billForm.Show();
        }


    }
}
