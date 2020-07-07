using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class DealerBillBreakupForm : BaseForm
    {
        DealerBillBreakup dealerBillBreakup;
        public int BillId;
        public int BillBreakupId;
        public DealerBillBreakupForm()
        {
            InitializeComponent();
        }

        private void BillBreakupForm_Load(object sender, EventArgs e)
        {
            EditBillBreakuDetail();
        }

        private void BillBreakupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (CallerForm.Name == "BillBreakupListForm")
            {
                ((DealerBillBreakupListForm)CallerForm).LoadBillBreakupList();
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            ShowFormAsFixedDialog(this, productListForm);
        }

        private void AmountAndQuantity_Changed(object sender, EventArgs e)
        {
            CalculateQuantityAndUnitPrice();
        }

        private void btnSaveBillBreakups_Click(object sender, EventArgs e)
        {
            SaveBillBreakup();
        }

        internal void OnProductSelect(int produectId, string productName)
        {
            dealerBillBreakup.ProductId = produectId;
            txtSelectedProductName.Text = productName;
        }

        private void EditBillBreakuDetail()
        {
            DealerBill bill = SharedRepo.DealerBillRepo.GetByID(BillId);
            if (bill == null)
            {
                MessageBox.Show("Bill not found");
                Close();
                return;
            }
            else if (bill.Dealer == null)
            {
                MessageBox.Show("Dealer not found");
                Close();
                return;
            }

            txtDealerName.Text = bill.Dealer.Name;
            txtBillDate.Text = bill.BillDate;
            txtTotalBillAmount.Text = bill.TotalAmount.ToString();
            txtTotalBreakupCount.Text = bill.DealerBillBreakupList.Count.ToString();
            txtTotalBreakupAmount.Text = bill.DealerBillBreakupList.Sum(x => x.TotalAmount).ToString();

            if (BillBreakupId != 0)
            {
                dealerBillBreakup = SharedRepo.DealerBillBreakupRepo.GetByID(BillBreakupId);
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
                dealerBillBreakup = new DealerBillBreakup();
                dealerBillBreakup.DealerBillId = BillId;
                dealerBillBreakup.EntryDate = DateHelper.GetTodayDateString();
            }
        }

        private void SaveBillBreakup()
        {
            dealerBillBreakup.EntityState = new ValidationState();
            dealerBillBreakup.TotalAmount = numTotalAmount.Value;
            dealerBillBreakup.QuantityInBox = (int)numQuantityInABox.Value;
            dealerBillBreakup.TotalBoxes = (int)numTotalBoxes.Value;
            dealerBillBreakup.TotalQuantity = (int)numTotalQuantity.Value;
            dealerBillBreakup.UnitPrice = Math.Round(numUnitPrice.Value, 2);
            dealerBillBreakup.UnitSellPrice = numUnitSellingPrice.Value;
            dealerBillBreakup.AvailableQuantity = (int)numAvailableQuantity.Value;
            dealerBillBreakup.ValidateDealerBillBreakup();

            if (dealerBillBreakup.EntityState.State == ValidationState.SUCCESS)
            {
                SharedRepo.DealerBillBreakupRepo.Save(dealerBillBreakup);
                Close();
            }
            else
            {
                MessageBox.Show(dealerBillBreakup.EntityState.StateMessage);
            }
        }

        private void CalculateQuantityAndUnitPrice()
        {
            try
            {
                numTotalQuantity.Value = numTotalBoxes.Value * numQuantityInABox.Value;
                numAvailableQuantity.Value = numTotalQuantity.Value;
                if (numTotalAmount.Value == 0)
                {
                    numUnitPrice.Value = 0;
                }
                else
                {
                    numUnitPrice.Value = numTotalAmount.Value / numTotalQuantity.Value;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void AmountChanging(object sender, KeyEventArgs e)
        {
            CalculateQuantityAndUnitPrice();
        }
    }
}
