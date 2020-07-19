using Stock_Management.Shared;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class ProductReportForm : BaseForm
    {
        public ProductReportForm()
        {
            InitializeComponent();
            dgvProductReport.AutoGenerateColumns = false;
            SetDataGridViewProperties(dgvProductReport);
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            LoadProductReportList();
        }

        private void dgvProductReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView_Selected_Cell_CellFormatting(sender, e);
        }

        private void chkIncludeBills_CheckedChanged(object sender, EventArgs e)
        {
            LoadProductReportList();
        }

        private void LoadProductReportList()
        {           
            dgvProductReport.DataSource = SharedRepo.DBRepo.GetProductReport(txtProductName.Text);
        }
    }
}
