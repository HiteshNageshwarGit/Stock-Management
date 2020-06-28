using StockEntity.DataEntity;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Repository
{
    public class BillBreakupRepository : BaseRepository<BillBreakup>
    {
        public BillBreakupRepository() : base()
        {

        }

        public void Save(BillBreakup BillBreakup)
        {
            if (BillBreakup.Id == 0)
            {
                Add(BillBreakup);
            }
            else
            {
                Update(BillBreakup);
            }
        }

        public List<BillBreakup> GetBillBreakupList(int billId)
        {
            return dbSet.Where(x => x.BillId == billId).ToList();
        }
    }
}
