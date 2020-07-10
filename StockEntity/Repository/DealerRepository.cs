//using StockEntity.Entity;
//using System.Collections.Generic;
//using System.Linq;

//namespace StockEntity.Repository
//{
//    public class DealerRepository : BaseRepository<Dealer>
//    {
//        public DealerRepository() : base()
//        {

//        }

//        public void Save(Dealer dealer)
//        {
//            if (dealer.Id == 0)
//            {
//                Add(dealer);
//            }
//            else
//            {
//                Update(dealer);
//            }
//        }

//        public bool DoesDelaerNameExists(Dealer dealer)
//        {
//            Dealer existingDealer = dbSet.Where(x => (x.Id != dealer.Id && x.Name.Trim().ToLower() == dealer.Name.Trim().ToLower())).FirstOrDefault();
//            if (existingDealer == null)
//            {
//                return false;
//            }
//            else
//            {
//                return true;
//            }
//        }

//        public bool DoesDefaulDealerNameExist()
//        {
//            if (GetDefaultDealer() == null)
//            {
//                Add(new Dealer() { Name = Person.DEFAULT_NAME });
//                if (GetDefaultDealer() == null)
//                {
//                    return false;
//                }
//                else
//                {
//                    return true;
//                }
//            }
//            else
//            {
//                return true;
//            }
//        }

//        public Dealer GetDefaultDealer()
//        {
//            return dbSet.Where(x => x.Name.ToLower() == Person.DEFAULT_NAME.ToLower()).FirstOrDefault();
//        }

//        public List<Dealer> GetDealerList()
//        {
//            return dbSet.OrderBy(x => x.Name).ToList();
//        }
//    }
//}
