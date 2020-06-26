using StockEntity.Entity;
using StockEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management.Shared
{
    public class Session
    {
        #region Properties

        public static ProductRepository ProductRepository { get; private set; }
        public static DealerRepository DealerRepo { get; private set; }
        public static BillRepository BillRepo { get; private set; }
        public static BillDetailRepository BillDetailRepo { get; private set; }

        #endregion        

        public static void InitializeSession()
        {
            DealerRepo = new DealerRepository();
            BillRepo = new BillRepository();
            BillDetailRepo = new BillDetailRepository();
            ProductRepository = new ProductRepository();
        }

    }
}
