using Stock_Management.Shared;
using StockEntity.EntityX;
using System;
using System.Collections.Generic;

namespace Stock_Management.Forms
{
    public partial class CustomerBillBreakupListForm : BaseForm
    {
        private int _customererBillId;
        public CustomerBillBreakupListForm(int customererBillId)
        {
            InitializeComponent();

            _customererBillId = customererBillId;
            dgvCustomerBillBreakupList.AutoGenerateColumns = false;
        }

        private void CustomerBillBreakupListForm_Load(object sender, EventArgs e)
        {
            List<CustomerBillBreakupReport> list = SharedRepo.DBRepo.GetCustomerBillBreakupList(_customererBillId);
            dgvCustomerBillBreakupList.DataSource = list;
            dgvCustomerBillBreakupList.ClearSelection();
        }
    }
}
