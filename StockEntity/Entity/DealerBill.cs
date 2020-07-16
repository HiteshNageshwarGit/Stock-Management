using StockEntity.Helper;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockEntity.Entity
{
    public class DealerBill : Bill
    {
        public int DealerId { get; set; }
        public string EntryDate { get; set; }
        public Dealer Dealer { get; set; }




        [NotMapped]
        public string DealerName { get; set; }

        [NotMapped]
        public int BillBreakupCount
        {
            get
            {
                return 0;// DealerBillBreakupList == null ? 0 : DealerBillBreakupList.Count;
            }
        }

        public new void Validate()
        {
            base.Validate();
            if (DateHelper.GetDateObject(BillDate).Date > DateHelper.GetDateObject(EntryDate).Date)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Bill Date can not be future Date";
            }
        }
        //public override string ToString()
        //{
        //    int breakupCount = 0;
        //    if (DealerBillBreakupList != null && DealerBillBreakupList.Count > 0)
        //    {
        //        breakupCount = DealerBillBreakupList.Count;
        //    }
        //    return breakupCount.ToString();
        //}
    }
}
