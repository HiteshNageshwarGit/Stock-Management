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

            histoty.Append("V 1.0.1.0");
            histoty.Append("\n # About detais included" +
                "\n # Included serial number in grids" +
                "\n # RAG implemented for Bill" +
                "\n # Grid styled" );

            histoty.Append("\n\n V 1.0.0.9");
            histoty.Append("\n # Unit Price calculatoin issue fixed" +
                           "\n # Price Code settings issue fixed");           

            txtVersionHistory.Text = histoty.ToString();
        }
    }
}
