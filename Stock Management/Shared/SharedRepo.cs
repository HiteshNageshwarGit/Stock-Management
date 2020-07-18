using StockEntity;

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
        public static DBRepository DBRepo { get; private set; }           
        #endregion        

        public static void InitializeSession()
        {
            DBRepo = new DBRepository();
        }

    }
}
