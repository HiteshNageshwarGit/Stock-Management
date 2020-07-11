using Stock_Management.Shared;
using StockEntity.EntityX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class CustomerBillBreakupListForm : BaseForm
    {
        public int CUSTOMER_BILL_ID { get; set; }
        public CustomerBillBreakupListForm()
        {
            InitializeComponent();
            dgvCustomerBillBreakupList.AutoGenerateColumns = false;
        }

        private void CustomerBillBreakupListForm_Load(object sender, EventArgs e)
        {
            List<CustomerBillBreakupRPT> list = SharedRepo.DBRepo.GetCustomerBillBreakupList(CUSTOMER_BILL_ID);
            dgvCustomerBillBreakupList.DataSource = list;
            dgvCustomerBillBreakupList.ClearSelection();            
        }
    }
}
