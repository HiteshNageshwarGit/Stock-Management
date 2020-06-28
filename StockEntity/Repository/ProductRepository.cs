using StockEntity.DataEntity;
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

        public List<Product> GetProductList(string productName)
        {
            return dbSet.Where(x => x.Name.ToLower().Contains(productName.ToLower()) || productName =="").OrderBy(x => x.Name).ToList();
        }
    }
}
