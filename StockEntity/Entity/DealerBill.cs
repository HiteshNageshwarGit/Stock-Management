using StockEntity.Helper;

namespace StockEntity.Entity
{
    public class DealerBill : BillBase
    {
        #region Entity Properties  
        public int DealerId { get; set; }
        public string EntryDate { get; set; }
        public Dealer Dealer { get; set; }
        #endregion

        public new void Validate()
        {
            base.Validate();
            if (DateHelper.GetDateObject(BillDate).Date > DateHelper.GetDateObject(EntryDate).Date)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Bill Date can not be future Date";
            }
        }
    }
}
