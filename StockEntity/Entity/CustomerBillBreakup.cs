using StockEntity.Helper;
using System.Text;

namespace StockEntity.Entity
{
    public class CustomerBillBreakup : BillBreakup
    {
        public int CustomerBillId { get; set; }
        public int DealerBillBreakupId { get; set; } // To track which batch was sold
        public CustomerBill CustomerBill { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder("Rs. " + TotalAmount.ToString());
            if (Product != null)
            {
                str.Append(" - " + Product.ToString());
            }
            if (CustomerBill != null)
            {
                str.Append(" - " + CustomerBill.ToString());
            }
            return str.ToString();
        }

        public void ValidateDealerBillBreakup()
        {
            if (CustomerBillId == 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Could not found Bill Id";
            }
            else
            {
                ValidateBillBreakup();
            }
        }
    }
}
