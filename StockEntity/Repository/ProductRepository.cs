using StockEntity.Entity;
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

        public Product GetProduct(string productName)
        {
            return dbSet.Where(x => x.Name.Trim().ToLower().Contains(productName.Trim().ToLower())).FirstOrDefault();
        }

        public List<Product> GetProductList(string productName)
        {
            return dbSet.Where(x => x.Name.ToLower().Contains(productName.ToLower()) || productName == "").OrderBy(x => x.Name).ToList();
        }
    }
}
