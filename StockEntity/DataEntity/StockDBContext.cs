using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DbSet<Product> ProductMasters { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillBreakup> BillBreakup { get; set; }

    }
}
