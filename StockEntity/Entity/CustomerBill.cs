using StockEntity.Helper;
using System.Collections.Generic;

namespace StockEntity.Entity
{
    public class CustomerBill : Bill
    {
        #region Entity Properties  
        public int CustomerId { get; set; }
        #endregion

        public Customer Customer { get; set; }

        public new void Validate()
        {
            if (CustomerId <= 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Customer Id not found";
            }
            base.Validate();
        }
        public override string ToString()
        {
            int breakupCount = 0;
            //if (CustomerBillBreakupList != null && CustomerBillBreakupList.Count > 0)
            //{
            //    breakupCount = CustomerBillBreakupList.Count;
            //}
            return breakupCount.ToString();
        }
    }
}
