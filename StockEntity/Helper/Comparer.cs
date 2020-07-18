using StockEntity.Entity;
using StockEntity.EntityX;
using System.Collections.Generic;

namespace StockEntity.Helper
{
    class Comparer : IEqualityComparer<ProductInCart>
    {
        public bool Equals(ProductInCart x, ProductInCart y)
        {
            return x.DealerBillBreakupId == y.DealerBillBreakupId;
        }
        public int GetHashCode(ProductInCart obj)
        {
            return obj.DealerBillBreakupId.GetHashCode();
        }
    }

    class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            return x.Id == y.Id;
        }
        public int GetHashCode(Product obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
