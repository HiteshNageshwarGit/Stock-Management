using StockEntity.Entity;
using System.Collections.Generic;
using System.Linq;

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
