using StockEntity.Entity;

namespace StockEntity.EntityX
{
    public class CustomerBillBreakupReport : BaseEntity
    {
        public string productName { get; set; }
        public decimal UnitPrice { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
