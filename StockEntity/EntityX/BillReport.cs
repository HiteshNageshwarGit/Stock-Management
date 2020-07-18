using StockEntity.Entity;

namespace StockEntity.EntityX
{
    public class BillReport : BaseEntity
    {
        public string PersonName { get; set; }
        public string BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int BreakupCount { get; set; }
        public decimal BreakupSum { get; set; }

        public override string ToString()
        {
            return PersonName + "|" + BillDate + "|" + TotalAmount + "|" + BreakupCount + "|" + BreakupSum;
        }
    }
}
