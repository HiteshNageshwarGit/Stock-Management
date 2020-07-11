using StockEntity.Entity;
using StockEntity.EntityX;
using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StockEntity
{
    public class DBRepository
    {
        private StockDBContext context; // do not allow caller to access the DBContext
        public DBRepository()
        {
            context = StockDBContext.GetStockDBContext();
        }

        #region Key Value
        public KeyValue GetKeyValue(string key)
        {
            var dd = context.KeyValues.Where(x => x.Key == key).FirstOrDefault();
            return dd;
        }
        #endregion

        #region Product
        public void SaveProduct(Product product)
        {
            product.TimeStamp = DateHelper.GetDateNowString_Sortable();
            product.Name = product.Name.Trim();
            if (product.Id == 0)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            else
            {
                context.Products.Attach(product);
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public virtual void DeleteProduct(int id)
        {
            Product productToDelete = context.Products.Find(id);
            DeleteProduct(productToDelete);
            context.SaveChanges();
        }

        public virtual void DeleteProduct(Product productToDelete)
        {
            if (context.Entry(productToDelete).State == EntityState.Detached)
            {
                context.Products.Attach(productToDelete);
            }
            context.Products.Remove(productToDelete);
            context.SaveChanges();
        }

        public Product GetProductByID(int id)
        {
            return context.Products.Find(id);
        }

        public bool DoesProductNameExists(Product product)
        {
            Product existingProduct = context.Products.Where(x => (x.Id != product.Id && x.Name.Trim().ToLower() == product.Name.Trim().ToLower())).FirstOrDefault();
            if (existingProduct == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Product> GetProductListForAdmin(string productName)
        {
            return context.Products.Where(x => x.Name.ToLower().Contains(productName.ToLower()) || productName == "").OrderBy(x => x.Name).Take(50).ToList();
        }
        #endregion

        #region Dealer
        public void SaveDealer(Dealer dealer)
        {
            dealer.TimeStamp = DateHelper.GetDateNowString_Sortable();
            dealer.Name = dealer.Name.Trim();
            dealer.Address = dealer.Address.Trim();
            if (dealer.Id == 0)
            {
                context.Dealers.Add(dealer);
                context.SaveChanges();
            }
            else
            {
                context.Dealers.Attach(dealer);
                context.Entry(dealer).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Dealer GetDealerByID(int id)
        {
            return context.Dealers.Find(id);
        }

        public bool DoesDealerNameExists(Dealer dealer)
        {
            Dealer existingDealer = context.Dealers.Where(x => (x.Id != dealer.Id && x.Name.Trim().ToLower() == dealer.Name.Trim().ToLower())).FirstOrDefault();
            if (existingDealer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DoesDefaulDealerNameExist()
        {
            if (GetDefaultDealer() == null)
            {
                SaveDealer(new Dealer() { Name = Person.DEFAULT_NAME, Address ="" });
                if (GetDefaultDealer() == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public Dealer GetDefaultDealer()
        {
            return context.Dealers.Where(x => x.Name.ToLower() == Person.DEFAULT_NAME.ToLower()).FirstOrDefault();
        }

        public List<Dealer> GetDealerList()
        {
            return context.Dealers.OrderBy(x => x.Name).ToList();
        }
        #endregion

        #region Customer
        public void SaveCustomer(Customer customer)
        {
            customer.TimeStamp = DateHelper.GetDateNowString_Sortable();
            customer.Name = customer.Name.Trim();
            customer.Address = customer.Address.Trim();
            if (customer.Id == 0)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            else
            {
                context.Customers.Attach(customer);
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool DoesCustomerNameExists(Customer customer)
        {
            Person existingCustomer = context.Customers
                .Where(x => (x.Id != customer.Id && (x.Name.Trim().ToLower() == customer.Name.Trim().ToLower()))
                                                 && (x.Address.Trim().ToLower() == customer.Address.Trim().ToLower()))
                .FirstOrDefault();
            if (existingCustomer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DoesDefaulCustomerNameExist()
        {
            if (GetDefaultCustomer() == null)
            {
                SaveCustomer(new Customer() { Name = Person.DEFAULT_NAME, Address ="" });
                if (GetDefaultCustomer() == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public Customer GetDefaultCustomer()
        {
            return context.Customers.Where(x => x.Name.ToLower() == Person.DEFAULT_NAME.ToLower()).FirstOrDefault();
        }

        public List<Customer> GetCustomerList()
        {
            return context.Customers.OrderBy(x => x.Name).ToList();
        }

        public Customer GetCustomerByID(int id)
        {
            return context.Customers.Find(id);
        }
        #endregion

        #region Dealer Bill
        public void SaveDealerBill(DealerBill bill)
        {
            bill.TimeStamp = DateHelper.GetDateNowString_Sortable();
            if (bill.Id == 0)
            {
                context.DealerBills.Add(bill);
                context.SaveChanges();
            }
            else
            {
                context.DealerBills.Attach(bill);
                context.Entry(bill).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public DealerBill GetDealerBillByID(int id)
        {
            return context.DealerBills.Find(id);
        }

        public List<DealerBill> GetDealerBillList(int dealerId)
        {
            //var dd = context.DealerBills.Where(db => db.DealerId == dealerId).Select(db => new DealerBill
            //{
            //    BillBreakupCount = db.DealerBillBreakupList.Count
            //}).ToList();

            return context.DealerBills.Where(x => x.DealerId == dealerId).Include(x => x.DealerBillBreakupList).OrderByDescending(x => x.EntryDate).ToList();
        }
        #endregion

        #region Dealer Bill Breakup
        public void SaveDealerBillBreakup(DealerBillBreakup BillBreakup)
        {
            BillBreakup.TimeStamp = DateHelper.GetDateNowString_Sortable();
            if (BillBreakup.Id == 0)
            {
                context.DealerBillBreakups.Add(BillBreakup);
                context.SaveChanges();
            }
            else
            {
                context.DealerBillBreakups.Attach(BillBreakup);
                context.Entry(BillBreakup).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public DealerBillBreakup GetDealerBillBreakupByID(int id)
        {
            return context.DealerBillBreakups.Find(id);
        }

        public List<DealerBillBreakup> GetDealerBillBreakupList(int billId)
        {
            return context.DealerBillBreakups.Where(x => x.DealerBillId == billId).OrderByDescending(x => x.EntryDate).ToList();
        }

        public DealerBillBreakup GetDealerBillBreakup(int billId)
        {
            return context.DealerBillBreakups.Where(x => x.Id == billId).FirstOrDefault();
        }
        #endregion

        #region Customer Bill & BillBreakup
        public void SaveCustomerBill(CustomerBill customerBill)
        {
            customerBill.TimeStamp = DateHelper.GetDateNowString_Sortable();
            if (customerBill.Id == 0)
            {
                context.CustomerBills.Add(customerBill);
                context.SaveChanges();
            }
            else
            {
                context.CustomerBills.Attach(customerBill);
                context.Entry(customerBill).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<CustomerBill> GetCustomerBillList(int customerId)
        {
            return context.CustomerBills.Where(x => x.CustomerId == customerId).OrderBy(x => x.BillDate).ToList();
        }

        public void SaveCustomerBillBreakup(CustomerBillBreakup customerBillBreakup)
        {
            customerBillBreakup.TimeStamp = DateHelper.GetDateNowString_Sortable();
            if (customerBillBreakup.Id == 0)
            {
                context.CustomerBillBreakups.Add(customerBillBreakup);
                context.SaveChanges();
            }
            else
            {
                context.CustomerBillBreakups.Attach(customerBillBreakup);
                context.Entry(customerBillBreakup).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void SaveCustomerBillBreakupList(CustomerBill customerBill, List<ProductInCart> productListInCart)
        {
            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    SaveCustomerBill(customerBill);
                    foreach (ProductInCart productInCart in productListInCart)
                    {
                        CustomerBillBreakup customerBillBreakup = new CustomerBillBreakup();

                        customerBillBreakup.CustomerBillId = customerBill.Id;
                        customerBillBreakup.DealerBillBreakupId = productInCart.DealerBillBreakupId;
                        customerBillBreakup.ProductId = productInCart.ProductId;
                        customerBillBreakup.TotalAmount = productInCart.SellingAmount;
                        customerBillBreakup.TotalQuantity = productInCart.SellingQuantity;
                        customerBillBreakup.UnitPrice = productInCart.SellingUnitPrice;
                        customerBillBreakup.TotalBoxes = productInCart.TotalBoxes;
                        customerBillBreakup.QuantityInBox = productInCart.QuantityInBox;
                        SaveCustomerBillBreakup(customerBillBreakup);

                        // Reduce available quantity
                        DealerBillBreakup dealerBillBreakup = context.DealerBillBreakups.Find(customerBillBreakup.DealerBillBreakupId);
                        if (dealerBillBreakup == null)
                        {
                            dbContextTransaction.Rollback();
                            throw new Exception("Dealer bill breakup is not found");
                        }
                        else if (dealerBillBreakup.AvailableQuantity < customerBillBreakup.TotalQuantity)
                        {
                            dbContextTransaction.Rollback();
                            throw new Exception("Available quantity is less than sold quantity");
                        }
                        dealerBillBreakup.AvailableQuantity = dealerBillBreakup.AvailableQuantity - customerBillBreakup.TotalQuantity;
                        SaveDealerBillBreakup(dealerBillBreakup);
                    }

                    dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw new Exception("Billing failed" + ex.Message);
                }
            }
        }

        //public List<CustomerBillBreakup> GetCustomerBillBreakupList(int customerBillId)
        //{
        //    return context.CustomerBillBreakups.Where(x => x.CustomerBillId == customerBillId).OrderBy(x => x.Id).ToList();
        //}

        public List<CustomerBillBreakupRPT> GetCustomerBillBreakupList(int billId)
        {
            List<CustomerBillBreakupRPT> list = (from CBB in context.CustomerBillBreakups
                                                 join P in context.Products on CBB.ProductId equals P.Id
                                                 where CBB.CustomerBillId == billId
                                                 select new CustomerBillBreakupRPT
                                                 {
                                                     productName = P.Name,
                                                     TotalAmount = CBB.TotalAmount,
                                                     TotalQuantity = CBB.TotalQuantity,
                                                     UnitPrice = CBB.UnitPrice
                                                 }).ToList();
            return list;
        }

        #endregion

        public List<ProductInCart> GetProductListForSelling(string productName)
        {
            productName = productName.Trim().ToLower();
            List<ProductInCart> exactMatchProductList = (from P in context.Products
                                                         where (productName == "" || P.Name.ToLower().Contains(productName))
                                                         join DBB in context.DealerBillBreakups on P.Id equals DBB.ProductId
                                                         where (DBB.AvailableQuantity > 0)
                                                         join DB in context.DealerBills on DBB.DealerBillId equals DB.Id
                                                         join D in context.Dealers on DB.DealerId equals D.Id

                                                         select new ProductInCart
                                                         {
                                                             ProductId = P.Id,
                                                             ProductName = P.Name,
                                                             DealerName = D.Name,
                                                             DealerBillDate = DB.BillDate,
                                                             QuantityInBox = DBB.QuantityInBox,
                                                             TotalBoxes = DBB.TotalBoxes,
                                                             TotalQuantity = DBB.TotalQuantity,
                                                             AvailableQuantity = DBB.AvailableQuantity,
                                                             SellingUnitPrice = DBB.UnitSellPrice,
                                                             DealerUnitPrice = DBB.UnitPrice,
                                                             DealerBillBreakupId = DBB.Id,
                                                             SellingQuantity = 1,
                                                             SellingAmount = DBB.UnitPrice

                                                         }).Take(50).ToList();

            if (productName.Trim().Split(' ').Length == 1)
            {
                return exactMatchProductList;
            }

            // Search each word of product name
            string[] splittedProductNames = productName.Split(' ');
            List<ProductInCart> splittedNameProductList = (from P in context.Products
                                                           where (splittedProductNames.Any(x => P.Name.ToLower().Contains(x)))
                                                           join DBB in context.DealerBillBreakups on P.Id equals DBB.ProductId
                                                           where (DBB.AvailableQuantity > 0)
                                                           join DB in context.DealerBills on DBB.DealerBillId equals DB.Id
                                                           join D in context.Dealers on DB.DealerId equals D.Id

                                                           select new ProductInCart
                                                           {
                                                               ProductId = P.Id,
                                                               ProductName = P.Name,
                                                               DealerName = D.Name,
                                                               DealerBillDate = DB.BillDate,
                                                               QuantityInBox = DBB.QuantityInBox,
                                                               TotalBoxes = DBB.TotalBoxes,
                                                               TotalQuantity = DBB.TotalQuantity,
                                                               AvailableQuantity = DBB.AvailableQuantity,
                                                               SellingUnitPrice = DBB.UnitSellPrice,
                                                               DealerUnitPrice = DBB.UnitPrice,
                                                               DealerBillBreakupId = DBB.Id,
                                                               SellingQuantity = 1,
                                                               SellingAmount = DBB.UnitPrice

                                                           }).Take(50).ToList();

            var mergedList = exactMatchProductList.Union(splittedNameProductList, new ProductInCartComparer()).ToList(); // merge by removing duplicate
            return mergedList;
        }
    }


}
