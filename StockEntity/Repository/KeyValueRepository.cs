
using StockEntity.DataEntity;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Repository
{
    public class KeyValueRepository : BaseRepository<KeyValue>
    {
        public KeyValueRepository() : base()
        {

        }
               
        public KeyValue GetKeyValue(string key)
        {
            var dd = dbSet.Where(x => x.Key == key).SingleOrDefault();
            return dd;
        }
    }
}
