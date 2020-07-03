using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockEntity.Entity
{
    public class DealerBill : Bill
    {

        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }
        public ICollection<DealerBillBreakup> DealerBillBreakupList { get; set; }

        public override string ToString()
        {
            int breakupCount = 0;
            if (DealerBillBreakupList != null && DealerBillBreakupList.Count > 0)
            {
                breakupCount = DealerBillBreakupList.Count;
            }
            return breakupCount.ToString();
        }
    }
}
