using StockEntity.Entity;
using System.Collections.Generic;
using System.Linq;

namespace StockEntity.Repository
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository() : base()
        {

        }

        public void Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                Add(customer);
            }
            else
            {
                Update(customer);
            }
        }

        public bool DoesCustomerNameExists(Customer customer)
        {
            Person existingCustomer = dbSet.Where(x => (x.Id != customer.Id && x.Name.Trim().ToLower() == customer.Name.Trim().ToLower())).FirstOrDefault();
            if (existingCustomer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Customer> GetCustomerList()
        {
            return dbSet.OrderBy(x => x.Name).ToList();
        }
    }
}
