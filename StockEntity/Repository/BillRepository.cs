using StockEntity.DataEntity;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Repository
{
    public class BillRepository : BaseRepository<Bill>
    {
        public BillRepository() : base()
        {

        }

        public List<Bill> GetBillList()
        {
            //return this.dbSet.Where(x => x.BillDate == startDate && x.BillDate <= endDate).ToList();
            return this.dbSet.ToList();
        }
    }
}
