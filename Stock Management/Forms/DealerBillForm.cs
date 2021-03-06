﻿using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillForm : BaseForm
    {
        private int _dealerBillId;
        private int _dealerId;
        private DealerBill dealerBill;
        private Dealer dealer;

        public DealerBillForm(int dealerId, int dealerBillId)
        {
            InitializeComponent();
            _dealerId = dealerId;
            _dealerBillId = dealerBillId;
            dtBillDate.CustomFormat = DateHelper.DATE_FORMAT;
            dtBillEntryDate.CustomFormat = DateHelper.DATE_FORMAT;
            dtBillDate.MaxDate = DateTime.Now;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            EditBill();
        }

        private void BillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm != null && CallerForm.Name != null)
            {
                if (CallerForm.Name == "BillListForm")
                {
                    ((BillListForm)CallerForm).LoadBillList();
                }
            }
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            SaveBill();
        }

        private void EditBill()
        {
            dealer = SharedRepo.DBRepo.GetDealerByID(_dealerId);
            if (dealer == null)
            {
                MessageBox.Show("Dealer details not found");
                Close();
                return;
            }
            txtDealerName.Text = dealer.Name;

            if (_dealerBillId != 0)
            {
                Text = "Edit Dealer Bill";
                dealerBill = SharedRepo.DBRepo.GetDealerBillByID(_dealerBillId);
                dtBillEntryDate.Value = DateHelper.GetDateObject(dealerBill.EntryDate);
                dtBillDate.Value = DateHelper.GetDateObject(dealerBill.BillDate);
                numBillAmount.Value = dealerBill.TotalAmount;
                txtRemarks.Text = dealerBill.Remarks;
            }
            else
            {
                Text = "Add Dealer Bill";
                dealerBill = new DealerBill();
                dtBillEntryDate.Value = DateHelper.GetDateNowObject();
            }
        }

        private void SaveBill()
        {
            dealerBill.ResetValidationError();
            dealerBill.DealerId = dealer.Id;
            dealerBill.EntryDate = DateHelper.GetDateString(dtBillEntryDate.Value); //lblEntyDate.Text;
            dealerBill.BillDate = DateHelper.GetDateString(dtBillDate.Value);
            dealerBill.TotalAmount = Math.Round(numBillAmount.Value, 2);
            dealerBill.Remarks = txtRemarks.Text;
            dealerBill.Validate();
            if (dealerBill.EntityState.State != ValidationState.SUCCESS)
            {
                MessageBox.Show(dealerBill.EntityState.StateMessage);
                return;
            }
            SharedRepo.DBRepo.SaveDealerBill((DealerBill)dealerBill);
            Close();
        }


    }
}
