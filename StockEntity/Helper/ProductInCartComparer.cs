using StockEntity.EntityX;
using System.Collections.Generic;

namespace StockEntity.Helper
{
    class ProductInCartComparer : IEqualityComparer<ProductInCart>
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
}
