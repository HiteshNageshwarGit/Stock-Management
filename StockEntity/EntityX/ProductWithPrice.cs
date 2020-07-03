using System.Security.Policy;

namespace StockEntity.EntityX
{
    public class ProductWithPrice
    {
        public string ProductName { get; set; }
        public string DealerName { get; set; }
        public string BillDate { get; set; }
        public int TotalQuantity { get; set; }
        public int RemainigQuantity { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal UnitSellPrice { get; set; }
        public string UnitPriceIncode { get; set; }
        public int DealerBillBreakupId { get; set; }


        public static string GetPriceInCode(decimal price)
        {
            string pricString = price.ToString();
            pricString.Replace('1', 'A');
            pricString.Replace('2', 'A');
            pricString.Replace('3', 'A');
            pricString.Replace('4', 'A');
            pricString.Replace('5', 'A');
            pricString.Replace('6', 'A');
            pricString.Replace('7', 'A');
            pricString.Replace('8', 'A');
            pricString.Replace('9', 'A');
            return pricString;
        }
    }


}
