using StockEntity.DataEntity;
using StockEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Repository
{
    public class DealerRepository : BaseRepository<Dealer>
    {
        public DealerRepository() : base()
        {

        }

        public void Save(Dealer dealer)
        {
            if (dealer.Id == 0)
            {
                Add(dealer);
            }
            else
            {
                Update(dealer);
            }
        }

        public List<Dealer> GetDealerList()
        {
            return this.dbSet.ToList();
        }
    }
}
