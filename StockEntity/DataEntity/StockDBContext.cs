using StockEntity.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StockEntity
{
    public class StockDBContext : DbContext
    {
        private static readonly object padlock = new object();
        private static StockDBContext instance = null;
        private StockDBContext() : base("name = StockDBContext")
        {
        }
        private StockDBContext(string dbFilePath) : base(dbFilePath)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public static StockDBContext GetStockDBContext()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new StockDBContext();
                    }
                }
            }
            return instance;
        }

        public DbSet<KeyValue> KeyValues { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Dealer> Dealers { get; set; }        
        public DbSet<DealerBill> DealerBills { get; set; }
        public DbSet<DealerBillBreakup> DealerBillBreakups { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBill> CustomerBills { get; set; }
        public DbSet<CustomerBillBreakup> CustomerBillBreakups { get; set; }

    }
}
