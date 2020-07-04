using StockEntity.Entity;
using StockEntity.EntityX;
using System.Collections.Generic;
using System.Linq;

namespace StockEntity.Repository
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository() : base()
        {

        }
        public void Save(Product product)
        {
            if (product.Id == 0)
            {
                Add(product);
            }
            else
            {
                Update(product);
            }
        }
        public bool DoesProductNameExists(Product product)
        {
            Product existingProduct = dbSet.Where(x => (x.Id != product.Id && x.Name.Trim().ToLower() == product.Name.Trim().ToLower())).FirstOrDefault();
            if (existingProduct == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Product GetProductForAdmin(string productName)
        {
            return dbSet.Where(x => x.Name.Trim().ToLower().Contains(productName.Trim().ToLower())).FirstOrDefault();
        }

        public List<Product> GetProductListForAdmin(string productName)
        {
            return dbSet.Where(x => x.Name.ToLower().Contains(productName.ToLower()) || productName == "").OrderBy(x => x.Name).Take(50).ToList();
        }

        public List<ProductInCart> GetProductListForSelling(string productName)
        {
            List<ProductInCart> productLisForReport = (from P in context.Products
                                                       where (P.Name.Contains(productName) || productName == "")
                                                       join DBB in context.DealerBillBreakups on P.Id equals DBB.ProductId
                                                       where (DBB.AvailableQuantity > 0)
                                                       join DB in context.DealerBills on DBB.DealerBillId equals DB.Id
                                                       join D in context.Dealers on DB.DealerId equals D.Id

                                                       select new ProductInCart
                                                       {
                                                           ProductId = P.Id,
                                                           ProductName = P.Name,
                                                           DealerName = D.Name,
                                                           DealerBillDate = DB.BillDate,
                                                           QuantityInBox = DBB.QuantityInBox,
                                                           TotalBoxes = DBB.TotalBoxes,
                                                           TotalQuantity = DBB.TotalQuantity,
                                                           AvailableQuantity = DBB.AvailableQuantity,
                                                           SellingUnitPrice = DBB.UnitSellPrice,
                                                           DealerUnitPrice = DBB.UnitPrice,
                                                           //UnitPriceIncode = ProductWithPrice.GetPriceInCode(DBB.UnitPrice),
                                                           DealerBillBreakupId = DBB.Id,
                                                           SellingQuantity = 1,
                                                           SellingAmount = DBB.UnitPrice

                                                       }).Take(100).ToList();
            return productLisForReport;

        }
    }
}
