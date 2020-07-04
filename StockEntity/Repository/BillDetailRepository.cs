﻿using StockEntity.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StockEntity.Repository
{
    public class DealerBillBreakupRepository : BaseRepository<DealerBillBreakup>
    {
        public DealerBillBreakupRepository() : base()
        {

        }

        public void Save(DealerBillBreakup BillBreakup)
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

        public List<DealerBillBreakup> GetBillBreakupList(int billId)
        {
            return dbSet.Where(x => x.DealerBillId == billId).ToList();
        }

        public DealerBillBreakup GetBillBreakup(int billId)
        {
            return dbSet.Where(x => x.Id == billId).Include(x => x.Product).FirstOrDefault();
        }
    }
}
