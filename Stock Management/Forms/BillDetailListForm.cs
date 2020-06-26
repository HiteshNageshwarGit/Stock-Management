using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class BillDetailListForm : BaseForm
    {
        List<BillDetail> billDetailsList;
        //BillDetail selectedBillDetail;
        public int BillId;
        public BillDetailListForm()
        {
            InitializeComponent();
            //dgvBillDetailList.AutoGenerateColumns = false;

            LoadBillDetailList();
        }

        private void LoadBillDetailList()
        {
            billDetailsList = Session.BillDetailRepo.GetBillDetailList(BillId);
            dgvBillDetailList.DataSource = billDetailsList;
        }

        private void btnAddBillBreakup_Click(object sender, EventArgs e)
        {
            BillDetailForm billDetailForm = new BillDetailForm();
            billDetailForm.BillId = BillId;
            billDetailForm.BillDetailId = 0;
            ShowFormAsDialog(this, billDetailForm);
        }
    }
}
