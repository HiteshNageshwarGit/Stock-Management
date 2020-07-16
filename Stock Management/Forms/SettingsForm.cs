using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class SettingsForm : BaseForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SavePriceDodes();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (SharedRepo.UserRole != SharedRepo.AdminUser)
            {
                MessageBox.Show("Please login as Admin to access this page");
                Close();
                return;
            }

            EditPriceCode();
        }


        private void btnSavePriceCode_Click(object sender, EventArgs e)
        {
            SavePriceDodes();
        }

        private void EditPriceCode()
        {
            txt1.Text = PriceCode.GetPriceCodeForNumber(1);
            txt2.Text = PriceCode.GetPriceCodeForNumber(2);
            txt3.Text = PriceCode.GetPriceCodeForNumber(3);
            txt4.Text = PriceCode.GetPriceCodeForNumber(4);
            txt5.Text = PriceCode.GetPriceCodeForNumber(5);
            txt6.Text = PriceCode.GetPriceCodeForNumber(6);
            txt7.Text = PriceCode.GetPriceCodeForNumber(7);
            txt8.Text = PriceCode.GetPriceCodeForNumber(8);
            txt9.Text = PriceCode.GetPriceCodeForNumber(9);
            txt0.Text = PriceCode.GetPriceCodeForNumber(0);
            txtDot.Text = PriceCode.GetPriceCodeForNumber(".");
        }

        private void SavePriceDodes()
        {
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_1, Value = txt1.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_2, Value = txt2.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_3, Value = txt3.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_4, Value = txt4.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_5, Value = txt5.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_6, Value = txt6.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_7, Value = txt7.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_8, Value = txt8.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_9, Value = txt9.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_0, Value = txt0.Text });
            SharedRepo.DBRepo.SavePriceCode(new KeyValue() { Key = PriceCode.KEY_DOT, Value = txtDot.Text });
            MessageBox.Show("Saved");
        }
    }
}
