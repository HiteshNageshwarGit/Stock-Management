using Stock_Management.Shared;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class ProductReportForm : BaseForm
    {
        public ProductReportForm()
        {
            InitializeComponent();
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            dgvProductReport.DataSource = SharedRepo.DBRepo.GetProductReport();
        }
    }
}
