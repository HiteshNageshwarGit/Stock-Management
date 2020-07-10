//using StockEntity.Entity;
//using StockEntity.EntityX;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;

//namespace StockEntity.Repository
//{
//    public class CustomerRepository : BaseRepository<Customer>
//    {
//        public CustomerRepository() : base()
//        {

//        }

//        public void SaveCustomer(Customer customer)
//        {
//            if (customer.Id == 0)
//            {
//                Add(customer);
//            }
//            else
//            {
//                Update(customer);
//            }
//        }

//        public bool DoesCustomerNameExists(Customer customer)
//        {
//            Person existingCustomer = dbSet.Where(x => (x.Id != customer.Id && x.Name.Trim().ToLower() == customer.Name.Trim().ToLower())).FirstOrDefault();
//            if (existingCustomer == null)
//            {
//                return false;
//            }
//            else
//            {
//                return true;
//            }
//        }

//        public bool DoesDefaulCustomerNameExist()
//        {
//            if (GetDefaultCustomer() == null)
//            {
//                Add(new Customer() { Name = Person.DEFAULT_NAME });
//                if (GetDefaultCustomer() == null)
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

//        public Customer GetDefaultCustomer()
//        {
//            return context.Customers.Where(x => x.Name == Person.DEFAULT_NAME).FirstOrDefault();
//        }

//        public List<Customer> GetCustomerList()
//        {
//            return dbSet.OrderBy(x => x.Name).ToList();
//        }

//        public void SaveCustomerBillBreakupList(CustomerBill customerBill, List<ProductInCart> productListInCart)
//        {
//            using (var dbContextTransaction = context.Database.BeginTransaction())
//            {
//                try
//                {
//                    context.CustomerBills.Add(customerBill);
//                    foreach (ProductInCart productInCart in productListInCart)
//                    {
//                        CustomerBillBreakup customerBillBreakup = new CustomerBillBreakup();

//                        customerBillBreakup.CustomerBillId = customerBill.Id;
//                        customerBillBreakup.DealerBillBreakupId = productInCart.DealerBillBreakupId;
//                        customerBillBreakup.ProductId = productInCart.ProductId;
//                        customerBillBreakup.TotalAmount = productInCart.SellingAmount;
//                        customerBillBreakup.TotalQuantity = productInCart.SellingQuantity;
//                        customerBillBreakup.UnitPrice = productInCart.SellingUnitPrice;
//                        customerBillBreakup.TotalBoxes = productInCart.TotalBoxes;
//                        customerBillBreakup.QuantityInBox = productInCart.QuantityInBox;
//                        context.CustomerBillBreakups.Add(customerBillBreakup);

//                        // Reduce available quantity
//                        DealerBillBreakup dealerBillBreakup = context.DealerBillBreakups.Find(customerBillBreakup.DealerBillBreakupId);
//                        if (dealerBillBreakup == null)
//                        {
//                            dbContextTransaction.Rollback();
//                            throw new Exception("Dealer bill breakup is not found");
//                        }
//                        else if (dealerBillBreakup.AvailableQuantity < customerBillBreakup.TotalQuantity)
//                        {
//                            dbContextTransaction.Rollback();
//                            throw new Exception("Available quantity is less than sold quantity");
//                        }
//                        dealerBillBreakup.AvailableQuantity = dealerBillBreakup.AvailableQuantity - customerBillBreakup.TotalQuantity;
//                        UpdateDealerBillBreakup(dealerBillBreakup);
//                    }

//                    dbContextTransaction.Commit();
//                }
//                catch (Exception ex)
//                {
//                    dbContextTransaction.Rollback();
//                }
//            }
//        }

//        public virtual void UpdateDealerBillBreakup(DealerBillBreakup dealerBillBreakup)
//        {
//            context.DealerBillBreakups.Attach(dealerBillBreakup);
//            context.Entry(dealerBillBreakup).State = EntityState.Modified;
//            context.SaveChanges();
//        }

//        public List<CustomerBill> GetCustomerBillList(int customerId)
//        {
//            return context.CustomerBills.Where(x => x.CustomerId == customerId).OrderBy(x => x.BillDate).ToList();
//        }

//        public List<CustomerBillBreakup> GetCustomerBillBreakupList(int customerBillId)
//        {
//            return context.CustomerBillBreakups.Where(x => x.CustomerBillId == customerBillId).OrderBy(x => x.Id).ToList();
//        }
//    }
//}
