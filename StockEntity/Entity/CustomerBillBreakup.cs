using StockEntity.Helper;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockEntity.Entity
{
    public class CustomerBillBreakup : BillBreakupBase
    {
        #region Entity Properties  
        public int CustomerBillId { get; set; }
        public int DealerBillBreakupId { get; set; } // To track which batch was sold
        [NotMapped]
        public new string Remarks { get; set; }
        #endregion

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
