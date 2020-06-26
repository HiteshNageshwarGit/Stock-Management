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
    public class BillDetailRepository : BaseRepository<BillDetail>
    {
        public BillDetailRepository() : base()
        {

        }

        public void Save(BillDetail billDetail)
        {
            if (billDetail.Id == 0)
            {
                Add(billDetail);
            }
            else
            {
                Update(billDetail);
            }
        }

        public List<BillDetail> GetBillDetailList(int billId)
        {
            var dd = dbSet.Include(x=>x.Product).ToList();
            // dbSet.Include(x=>x.Product). ToList();
            //Where(x => x.BillId == billId).ToList();
            //OrderByDescending(x => x.EntryDate).ToList();
            return dd;
        }
    }
}
