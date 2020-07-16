using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.EntityX;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillBreakupForm : BaseForm
    {
        private DealerBillBreakup dealerBillBreakup;
        private  int _dealerBillId;
        private  int _dealerBillBreakupId;
        public DealerBillBreakupForm(int dealerBillId, int dealerBillBreakupId)
        {
            InitializeComponent();
            _dealerBillId = dealerBillId;
            _dealerBillBreakupId = dealerBillBreakupId;
            PrepareTooltips(this);
        }

        private void BillBreakupForm_Load(object sender, EventArgs e)
        {
            EditBillBreakuDetail();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                OpenSearchProductForm();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                SaveBillBreakup(false);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            OpenSearchProductForm();
        }

        private void NumericControl_ValueChange(object sender, EventArgs e)
        {
            // On up/down key get value direct from control
            CalculateQuantityAndUnitPrice(numTotalAmount.Value, numTotalBoxes.Value, numQuantityInABox.Value);
        }
        private void NumericControl_KeyUp(object sender, KeyEventArgs e)
        {
            // On key up explicitly get value from text box
            CalculateQuantityAndUnitPrice(decimal.Parse(numTotalAmount.Controls[1].Text),
                                                        decimal.Parse(numTotalBoxes.Controls[1].Text),
                                                        decimal.Parse(numQuantityInABox.Controls[1].Text));
        }

        private void NumericControlWithoutDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericControlWithoutDecimalKeyPress(sender, e);
        }

        private void btnSaveBillBreakups_Click(object sender, EventArgs e)
        {
            SaveBillBreakup(true);
        }

        private void btnSaveDBBNClose_Click(object sender, EventArgs e)
        {
            SaveBillBreakup(false);
        }

        internal void OnProductSelect(int produectId, string productName)
        {
            dealerBillBreakup.ProductId = produectId;
            txtSelectedProductName.Text = productName;
        }

        private void EditBillBreakuDetail()
        {
            ShowFormInGroupBox(this, grpBoxBrakupCount, new DealerBillBreakupCountForm(_dealerBillId));

            if (_dealerBillBreakupId != 0)
            {
                Text = "Edit Dealer Bill Breakup";
                dealerBillBreakup = SharedRepo.DBRepo.GetDealerBillBreakupByID(_dealerBillBreakupId);
                if (dealerBillBreakup == null)
                {
                    btnSaveBillBreakups.Enabled = false;
                    return;
                }
                else
                {
                    if (dealerBillBreakup.Product != null)
                    {
                        txtSelectedProductName.Text = dealerBillBreakup.Product.Name;
                    }
                    numTotalAmount.Value = dealerBillBreakup.TotalAmount;
                    numTotalBoxes.Value = dealerBillBreakup.TotalBoxes;
                    numQuantityInABox.Value = dealerBillBreakup.QuantityInBox;
                    numTotalQuantity.Value = dealerBillBreakup.TotalQuantity;
                    numAvailableQuantity.Value = dealerBillBreakup.AvailableQuantity;
                    numUnitPrice.Value = dealerBillBreakup.UnitPrice;
                    numUnitSellingPrice.Value = dealerBillBreakup.UnitSellPrice;
                }
            }
            else
            {
                Text = "Add Dealer Bill Breakup";
                dealerBillBreakup = new DealerBillBreakup();
                dealerBillBreakup.DealerBillId = _dealerBillId;
                dealerBillBreakup.EntryDate = DateHelper.GetTodayDateString();
            }
        }

        private void SaveBillBreakup(bool saveAndNew)
        {
            dealerBillBreakup.EntityState = new ValidationState();
            dealerBillBreakup.TotalAmount = Math.Round(numTotalAmount.Value, 2);
            dealerBillBreakup.QuantityInBox = (int)numQuantityInABox.Value;
            dealerBillBreakup.TotalBoxes = (int)numTotalBoxes.Value;
            dealerBillBreakup.TotalQuantity = (int)numTotalQuantity.Value;
            dealerBillBreakup.UnitPrice = Math.Round(numUnitPrice.Value, 2);
            dealerBillBreakup.UnitSellPrice = numUnitSellingPrice.Value;
            dealerBillBreakup.AvailableQuantity = (int)numAvailableQuantity.Value;
            dealerBillBreakup.ValidateDealerBillBreakup();

            if (dealerBillBreakup.EntityState.State == ValidationState.SUCCESS)
            {
                SharedRepo.DBRepo.SaveDealerBillBreakup(dealerBillBreakup);
                if (CallerForm == null || CallerForm.Name == null)
                {
                    return;
                }
                else if (CallerForm.Name == "DealerBillBreakupListForm")
                {
                    ((DealerBillBreakupListForm)CallerForm).LoadBillBreakupList(saveAndNew);
                }
                Close();
            }
            else
            {
                MessageBox.Show(dealerBillBreakup.EntityState.StateMessage);
            }
        }


        private void CalculateQuantityAndUnitPrice(decimal totalAmount, decimal totalBoxes, decimal quantityInABox)
        {
            try
            {
                numTotalQuantity.Value = totalBoxes * quantityInABox;
                numAvailableQuantity.Value = numTotalQuantity.Value;
                if (totalAmount == 0)
                {
                    numUnitPrice.Value = 0;
                }
                else
                {
                    numUnitPrice.Value = totalAmount / numTotalQuantity.Value;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void OpenSearchProductForm()
        {
            ProductListForm productListForm = new ProductListForm();
            ShowFormAsFixedDialog(this, productListForm);
        }


    }
}
