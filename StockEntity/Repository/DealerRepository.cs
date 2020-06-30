using StockEntity.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

        public bool DoesDelaerNameExists(Dealer dealer)
        {
            Dealer existingDealer = dbSet.Where(x => (x.Id != dealer.Id && x.Name.Trim().ToLower() == dealer.Name.Trim().ToLower())).FirstOrDefault();
            if (existingDealer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Dealer> GetDealerList()
        {
            return this.dbSet.OrderBy(x => x.Name).ToList();
        }
    }
}
