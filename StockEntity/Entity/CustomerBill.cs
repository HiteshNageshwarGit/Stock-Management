using System.Collections.Generic;

namespace StockEntity.Entity
{
    public class CustomerBill : Bill
    {
        public int CustomerId { get; set; }        
        public Customer Customer { get; set; }
        public ICollection<CustomerBillBreakup> CustomerBillBreakupList { get; set; }

        public override string ToString()
        {
            int breakupCount = 0;
            if (CustomerBillBreakupList != null && CustomerBillBreakupList.Count > 0)
            {
                breakupCount = CustomerBillBreakupList.Count;
            }
            return breakupCount.ToString();
        }
    }
}
