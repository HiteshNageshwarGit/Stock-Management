using Stock_Management.Shared;
using StockEntity.Entity;
using System;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class AboutForm : BaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            string appVersion = ConfigurationManager.AppSettings.Get("ApplicationVersion");
            if (appVersion == null)
            {
                appVersion = "Unknown";
            }
            txtAppVersion.Text = appVersion;

            KeyValue dbVersion = SharedRepo.DBRepo.GetKeyValue(SharedRepo.DBVersion);
            if (dbVersion == null)
            {
                txtDBVersion.Text = "Unknown";
            }
            else
            {
                txtDBVersion.Text = dbVersion.Value;
            }

            StringBuilder histoty = new StringBuilder();

            histoty.Append("\n\n V 1.0.1.2");
            histoty.Append("\n # Added stock RAG in Product Stock Report");
            histoty.Append("\n # Issue fix - Dealer Bill Breakup - on emptying numeric value");
            histoty.Append("\n # Dealer Bill Breakup List - Added Available Quanity");
            histoty.Append("\n # Dealer Bill Breakup List - Reordered columns");

            histoty.Append("\n\n V 1.0.1.1");
            histoty.Append("\n # Showing RAG when discrepancies found");
            histoty.Append("\n # RAG implemented in Dealer Bill Breakup list when. Recalculating Total Amount, Total Quantity");

            histoty.Append("\n\nV 1.0.1.0");
            histoty.Append("\n # About detais included");
            histoty.Append("\n # Included serial number in grids");
            histoty.Append("\n # RAG implemented for Bill");
            histoty.Append("\n # Grid styled");

            histoty.Append("\n\n V 1.0.0.9");
            histoty.Append("\n # Unit Price calculatoin issue fixed");
            histoty.Append("\n # Price Code settings issue fixed");

            txtVersionHistory.Text = histoty.ToString();
        }
    }
}
