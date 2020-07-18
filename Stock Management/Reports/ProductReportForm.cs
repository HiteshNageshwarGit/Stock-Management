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
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            dgvProductReport.DataSource = SharedRepo.DBRepo.GetProductReport();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.Tomato;
            }
        }
    }
}
