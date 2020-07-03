using StockEntity.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StockEntity.Repository
{
    public class DealerBillRepository : BaseRepository<DealerBill>
    {
        public DealerBillRepository() : base()
        {

        }

        public void Save(DealerBill bill)
        {
            if (bill.Id == 0)
            {
                Add(bill);
            }
            else
            {
                Update(bill);
            }
        }

        public List<DealerBill> GetBillList(int dealerId)
        {
            return dbSet.Where(x => x.DealerId == dealerId).Include(x => x.DealerBillBreakupList).OrderBy(x => x.BillDate).ToList();
        }
    }
}
