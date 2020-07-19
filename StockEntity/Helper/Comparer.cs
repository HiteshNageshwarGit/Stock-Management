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

    class ProductReportComparer : IEqualityComparer<ProductReport>
    {
        public bool Equals(ProductReport x, ProductReport y)
        {
            return x.Id == y.Id;
        }
        public int GetHashCode(ProductReport obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
