using StockEntity.Helper;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockEntity.Entity
{
    public class CustomerBillBreakup : BillBreakup
    {
        #region Entity Properties  
        public int CustomerBillId { get; set; }
        public int DealerBillBreakupId { get; set; } // To track which batch was sold
        [NotMapped]
        public new string Remarks { get; set; }
        #endregion

        public CustomerBill CustomerBill { get; set; }


        //public string ProductName { get; set; }

        //public override string ToString()
        //{
        //    StringBuilder str = new StringBuilder("Rs. " + TotalAmount.ToString());
        //    if (Product != null)
        //    {
        //        str.Append(" - " + Product.ToString());
        //    }
        //    if (CustomerBill != null)
        //    {
        //        str.Append(" - " + CustomerBill.ToString());
        //    }
        //    return str.ToString();
        //}

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
