using StockEntity.Helper;
using System.Collections.Generic;

namespace StockEntity.Entity
{
    public class CustomerBill : BillBase
    {
        #region Entity Properties  
        public int CustomerId { get; set; }
        #endregion

        public new void Validate()
        {
            if (CustomerId <= 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Customer Id not found";
            }
            base.Validate();
        }
    }
}
