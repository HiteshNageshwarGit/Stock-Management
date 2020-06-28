using StockEntity.Repository;

namespace Stock_Management.Shared
{
    public class SharedRepo
    {
        #region Properties
        public static ProductRepository ProductRepository { get; private set; }
        public static DealerRepository DealerRepo { get; private set; }
        public static BillRepository BillRepo { get; private set; }
        public static BillBreakupRepository BillBreakupRepo { get; private set; }
        #endregion        

        public static void InitializeSession()
        {
            DealerRepo = new DealerRepository();
            BillRepo = new BillRepository();
            BillBreakupRepo = new BillBreakupRepository();
            ProductRepository = new ProductRepository();
        }

    }
}
