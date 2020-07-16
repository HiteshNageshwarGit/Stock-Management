namespace StockEntity.EntityX
{
    public class DealerBillReport
    {
        public int Id { get; set; }
        public int DealerId { get; set; }   
        public string DealerName { get; set; }
        public string BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int BreakupCount { get; set; }
        public decimal BreakupSum { get; set; }
    }
}
