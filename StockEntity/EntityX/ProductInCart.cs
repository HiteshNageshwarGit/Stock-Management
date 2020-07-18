using StockEntity.Entity;
using StockEntity.Helper;

namespace StockEntity.EntityX
{
    public class ProductInCart : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int DealerBillBreakupId { get; set; }
        public string DealerName { get; set; }
        public string DealerBillDate { get; set; }
        public int QuantityInBox { get; set; }
        public int TotalBoxes { get; set; }
        public int TotalQuantity { get; set; } // Total quantiy when dealer bill entry was made
        public int AvailableQuantity { get; set; } // Available quantity, sell after sell
        public decimal DealerUnitPrice { get; set; }
        public decimal SellingUnitPrice { get; set; }
        public int SellingQuantity { get; set; }
        public decimal SellingAmount { get; set; } // SellingUnitPrice * SellingQuantity

        public string DealerUnitPriceInCode
        {
            get
            {
                return PriceCode.GetPriceCodeForNumber(DealerUnitPrice);
            }
        }

        public ProductInCart ShallowCopy() // copy product data by value
        {
            return (ProductInCart)MemberwiseClone();
        }
    }
}
