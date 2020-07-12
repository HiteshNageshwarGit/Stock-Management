using StockEntity.Helper;
using System.Text;

namespace StockEntity.Entity
{
    public class DealerBillBreakup : BillBreakup
    {
        #region Entity Properties  
        public string EntryDate { get; set; }
        public int DealerBillId { get; set; } // Bill ID o
        public decimal UnitSellPrice { get; set; } // Price to sell product to customers
        public int AvailableQuantity { get; set; } // same as when making first entry, update when sold to customer
        #endregion


       public DealerBill DealerBill { get; set; }

        //public override string ToString()
        //{
        //    StringBuilder str = new StringBuilder(" " + TotalAmount.ToString());
        //    if (Product != null)
        //    {
        //        str.Append(" - " + Product.ToString());
        //    }
        //    if (DealerBill != null)
        //    {
        //        str.Append(" - " + DealerBill.ToString());
        //    }
        //    return str.ToString();
        //}

        public void ValidateDealerBillBreakup()
        {
            if (DealerBillId == 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Could not found Bill Id";
            }
            else
            {
                ValidateBillBreakup();
            }
            if (UnitSellPrice <= 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Unit Selling Price should be greater than 0";
            }
            else if (UnitSellPrice <= UnitPrice)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Unit Selling Price should be greater than Unit Price";
            }
        }
    }
}
