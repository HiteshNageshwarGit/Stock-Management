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
    public class BillRepository : BaseRepository<Bill>
    {
        public BillRepository() : base()
        {

        }

        //public Bill GetBill(int billId)
        //{
        //    var dd = dbSet.Where(x => x.Dealer.Id ==1).ToList();
        //    return null;
        //}

        public List<Bill> GetBillList(int dealerId)
        {
            return this.dbSet.Where(x => x.DealerId == dealerId).OrderByDescending(x => x.BillDate).ToList();
        }



        //public Bill GetBill(int dealerId)
        //{
        //    string query = " SELECT 	B.Id, DealerId, D.Name AS DealerName, BillDate, BillEntryDate, TotalAmount, B.Remarks ";
        //    query += " FROM BILL B ";
        //    query += " INNER JOIN Dealer D ON D.Id = B.Id";
        //    query += " WHERE B.Id = 1	";
        //    Bill kk=  dbSet.SqlQuery(query).Single();
        //    return kk;
        //}
    }
}
