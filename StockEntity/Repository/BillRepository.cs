using StockEntity.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StockEntity.Repository
{
    public class BillRepository : BaseRepository<Bill>
    {
        public BillRepository() : base()
        {

        }

        public void Save(Bill bill)
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

        public List<Bill> GetBillList(int dealerId)
        {
            var dd = dbSet.Where(x => x.DealerId == dealerId).Include(x => x.BillBreakupList).OrderBy(x => x.BillDate).ToList();
            return dd;
        }
    }
}
