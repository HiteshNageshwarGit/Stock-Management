using StockEntity.Entity;

namespace StockEntity.EntityX
{
    public class ProductReport : BaseEntity
    {
        public string ProductName { get; set; }       
        public int AvailableQuantity { get; set; }
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
    }
}
