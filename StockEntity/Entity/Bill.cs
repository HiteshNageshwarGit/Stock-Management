using StockEntity.Helper;

namespace StockEntity.Entity
{
    public partial class Bill : BaseEntity
    {
        #region Entity Properties           
        public string BillDate { get; set; }
        public string EntryDate { get; set; }
        public decimal TotalAmount { get; set; }
        #endregion

        public void ValidateBill()
        {            
            if (TotalAmount <= 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage = "Bill amount should be greate than 0";
            }
        }

    }
}
