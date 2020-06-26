using StockEntity.DataEntity;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Product> GetProductList()
        {
            return this.dbSet.OrderBy(x => x.Name).ToList();
        }
    }
}
