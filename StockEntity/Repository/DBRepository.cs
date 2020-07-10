using StockEntity.Entity;
using StockEntity.EntityX;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StockEntity
{
    public class DBRepository
    {
        private StockDBContext context;
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
                SaveDealer(new Dealer() { Name = Person.DEFAULT_NAME });
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
            Person existingCustomer = context.Customers.Where(x => (x.Id != customer.Id && x.Name.Trim().ToLower() == customer.Name.Trim().ToLower())).FirstOrDefault();
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
                SaveCustomer(new Customer() { Name = Person.DEFAULT_NAME });
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
            return context.Customers.Where(x => x.Name == Person.DEFAULT_NAME).FirstOrDefault();
        }

        public List<Customer> GetCustomerList()
        {
            return context.Customers.OrderBy(x => x.Name).ToList();
        }

        public Customer GetCustomerByID(int id)
        {
            return context.Customers.Find(id);
        }

        public void SaveCustomerBillBreakupList(CustomerBill customerBill, List<ProductInCart> productListInCart)
        {
            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.CustomerBills.Add(customerBill);
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
                        context.CustomerBillBreakups.Add(customerBillBreakup);

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
                        UpdateDealerBillBreakup(dealerBillBreakup);
                    }

                    dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                }
            }
        }

        public void UpdateDealerBillBreakup(DealerBillBreakup dealerBillBreakup)
        {
            context.DealerBillBreakups.Attach(dealerBillBreakup);
            context.Entry(dealerBillBreakup).State = EntityState.Modified;
            context.SaveChanges();
        }

        public List<CustomerBill> GetCustomerBillList(int customerId)
        {
            return context.CustomerBills.Where(x => x.CustomerId == customerId).OrderBy(x => x.BillDate).ToList();
        }

        public List<CustomerBillBreakup> GetCustomerBillBreakupList(int customerBillId)
        {
            return context.CustomerBillBreakups.Where(x => x.CustomerBillId == customerBillId).OrderBy(x => x.Id).ToList();
        }
        #endregion

        #region
        public void SaveDealerBill(DealerBill bill)
        {
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
            return context.DealerBills.Where(x => x.DealerId == dealerId).Include(x => x.DealerBillBreakupList).OrderBy(x => x.BillDate).ToList();
        }
        #endregion

        #region Dealer Bill Breakup
        public void SaveDealerBillBreakup(DealerBillBreakup BillBreakup)
        {
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
            return context.DealerBillBreakups.Where(x => x.DealerBillId == billId).ToList();
        }

        public DealerBillBreakup GetBillBreakup(int billId)
        {
            return context.DealerBillBreakups.Where(x => x.Id == billId).Include(x => x.Product).FirstOrDefault();
        }
        #endregion

        public List<ProductInCart> GetProductListForSelling(string productName)
        {
            List<ProductInCart> productLisForReport = (from P in context.Products
                                                       where (P.Name.Contains(productName) || productName == "")
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
                                                           //UnitPriceIncode = ProductWithPrice.GetPriceInCode(DBB.UnitPrice),
                                                           DealerBillBreakupId = DBB.Id,
                                                           SellingQuantity = 1,
                                                           SellingAmount = DBB.UnitPrice

                                                       }).Take(100).ToList();
            return productLisForReport;

        }
    }
}
