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
            dgvProductReport.AutoGenerateColumns = false;
            SetDataGridViewProperties(dgvProductReport);
            CollBillDetails.UseColumnTextForLinkValue = true;
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            LoadProductListWillBillDetails();
        }

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
            LoadProductListWillBillDetails();
        }

        private void dgvProductReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView_Selected_Cell_CellFormatting(sender, e);
        }

        private void chkIncludeBills_CheckedChanged(object sender, EventArgs e)
        {
            LoadProductListWillBillDetails();
        }

        private void LoadProductListWillBillDetails()
        {           
            dgvProductReport.DataSource = SharedRepo.DBRepo.LoadProductListWillBillDetails(txtProductName.Text);
        }
    }
}
