using StockEntity.DataEntity;
using StockEntity.Entity;
using System.Collections.Generic;
using System.Linq;

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
            return this.dbSet.OrderBy(x => x.Name).ToList();
        }
    }
}
