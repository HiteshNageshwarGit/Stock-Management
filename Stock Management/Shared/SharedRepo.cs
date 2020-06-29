using StockEntity.Repository;

namespace Stock_Management.Shared
{
    public class SharedRepo
    {
        public const string DBVersion = "DBVersion";
        public const string DBBackupDir = "DBBackupDir";
        public const string AdminUser = "AdminUser";
        public const string AdminPassword = "AdminPassword";
        public const string GeneralUser = "GeneralUser";
        public static string UserRole { get; set; }
        #region Properties

        public static KeyValueRepository keyValueRepo { get; private set; }
        public static ProductRepository ProductRepo { get; private set; }
        public static DealerRepository DealerRepo { get; private set; }
        public static BillRepository BillRepo { get; private set; }
        public static BillBreakupRepository BillBreakupRepo { get; private set; }
        #endregion        

        public static void InitializeSession()
        {
            keyValueRepo = new KeyValueRepository();
            DealerRepo = new DealerRepository();
            BillRepo = new BillRepository();
            BillBreakupRepo = new BillBreakupRepository();
            ProductRepo = new ProductRepository();
        }

    }
}
