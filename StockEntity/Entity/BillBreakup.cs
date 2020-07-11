using StockEntity.Helper;

namespace StockEntity.Entity
{
    public partial class BillBreakup : BaseEntity
    {
        #region Entity Properties  
        public int ProductId { get; set; }       
        public int QuantityInBox { get; set; }
        public int TotalBoxes { get; set; }
        public int TotalQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        #endregion


        public Product Product { get; set; }

        public void ValidateBillBreakup()
        {
            if (ProductId == 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Could not found Product Id";
            }
            if (TotalAmount <= 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Amount should be greater than 0";
            }            
        }
    }
}
