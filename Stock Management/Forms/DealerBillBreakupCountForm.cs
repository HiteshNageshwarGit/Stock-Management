using Stock_Management.Shared;
using StockEntity.EntityX;
using System.Drawing;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillBreakupCountForm : BaseForm
    {
        private int _dealerBillId;
        public DealerBillBreakupCountForm(int dealerBillId)
        {
            _dealerBillId = dealerBillId;
            InitializeComponent();
        }

        private void DealerBillBreakupCountForm_Load(object sender, System.EventArgs e)
        {
            LoadDealerBillBreakupCount();
        }

        private void LoadDealerBillBreakupCount()
        {
            DealerBillReport dealerBillReport = SharedRepo.DBRepo.GetDealerBillReport(_dealerBillId);
            if (dealerBillReport == null)
            {
                MessageBox.Show("Could not load breakup count");
                return;
            }

            txtDealerName.Text = dealerBillReport.DealerName;
            txtBillDate.Text = dealerBillReport.BillDate;
            txtTotalBillAmount.Text = dealerBillReport.TotalAmount.ToString();
            txtTotalBreakupCount.Text = dealerBillReport.BreakupCount.ToString();
            txtTotalBreakupAmount.Text = dealerBillReport.BreakupSum.ToString();

            if (dealerBillReport.BreakupSum == dealerBillReport.TotalAmount)
            {
                txtTotalBreakupAmount.BackColor = Color.LightGreen;
            }
            else if (dealerBillReport.BreakupSum > dealerBillReport.TotalAmount)
            {
                txtTotalBreakupAmount.BackColor = Color.Red;
            }
            else
            {
                txtTotalBreakupAmount.BackColor = Color.Orange;
            }
        }
    }
}
