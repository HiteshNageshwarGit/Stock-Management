﻿using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillListForm : BaseForm
    {
        private int _personType; // Can be Dealer or Customer
        private int _personId; // Can be Dealer ID or Customer ID
        public BillListForm(int personType, int personId)
        {
            InitializeComponent();
            _personType = personType;
            _personId = personId;
        }

        private void BillListForm_Load(object sender, EventArgs e)
        {
            if (_personType == Person.DEALER)
            {
                Text = "Dealer Bill List";
                btnAddBill.Text = "Add Dealer Bill";
            }
            else if (_personType == Person.CUSTOMER)
            {
                Text = "Customer Bill List";
                btnAddBill.Text = "Add Customer Bill";
                btnAddBill.Visible = false;
                ColBillShowLink.Visible = false;
            }
            else
            {
                Text = "Unknown";
                return;
            }

            SetFormBehaviour();

            dgvBillList.AutoGenerateColumns = false;
            ColBillShowLink.UseColumnTextForLinkValue = true;
            ColShowBillBreakups.UseColumnTextForLinkValue = true;

            LoadBillList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                OpenDealerBillForm(0);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            OpenDealerBillForm(0);
        }

        private void dgvBillList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            int selectedBillId = ((Bill)dgvBillList.Rows[e.RowIndex].DataBoundItem).Id;
            if (_personType == Person.DEALER)
            {
                if (GetSelectedCellText(dgvBillList, e) == "Details")
                {
                    OpenDealerBillForm(selectedBillId);
                }
                else if (GetSelectedCellText(dgvBillList, e) == "Breakups")
                {
                    DealerBillBreakupListForm billBreakupForm = new DealerBillBreakupListForm(selectedBillId);
                    ShowFormResizableAsDialog(this, billBreakupForm);
                }
            }
            else if (_personType == Person.CUSTOMER)
            {
                if (GetSelectedCellText(dgvBillList, e) == "Details")
                {
                    CustomerBillBreakupListForm customerBillBreakupListForm = new CustomerBillBreakupListForm(selectedBillId);
                    ShowFormResizableAsDialog(this, customerBillBreakupListForm);
                }
            }
        }

        internal void LoadBillList()
        {
            if (_personType == Person.DEALER)
            {
                Dealer dealer = SharedRepo.DBRepo.GetDealerByID(_personId);
                if (dealer == null)
                {
                    MessageBox.Show("Dealer not found");
                    return;
                }
                txtPersonName.Text = dealer.Name;
                List<DealerBill> billList = SharedRepo.DBRepo.GetDealerBillList(_personId);
                dgvBillList.DataSource = billList;
            }
            else if (_personType == Person.CUSTOMER)
            {
                Customer customer = SharedRepo.DBRepo.GetCustomerByID(_personId);
                if (customer == null)
                {
                    MessageBox.Show("Dealer not found");
                    return;
                }
                txtPersonName.Text = customer.Name;
                List<CustomerBill> billList = SharedRepo.DBRepo.GetCustomerBillList(_personId);
                dgvBillList.DataSource = billList;
            }
            dgvBillList.ClearSelection();
        }

        public void SetFormBehaviour()
        {
        }

        private void OpenDealerBillForm(int billId)
        {
            DealerBillForm billForm = new DealerBillForm(_personId, billId);
            ShowFormAsFixedDialog(this, billForm);
        }
    }
}
