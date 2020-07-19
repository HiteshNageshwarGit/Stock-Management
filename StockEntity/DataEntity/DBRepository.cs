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
        public void SaveKeyalue(KeyValue keyValue)
        {
            keyValue.TimeStamp = DateHelper.GetDateNowString_Sortable();
            if (keyValue.Id == 0)
            {
                KeyValue existingKeyValue = context.KeyValues.Where(x => x.Key.Trim().ToLower() == keyValue.Key.Trim().ToLower()).FirstOrDefault();
                if (existingKeyValue == null)
                {
                    context.KeyValues.Add(keyValue);
                    context.SaveChanges();
                }
                else
                {
                    existingKeyValue.TimeStamp = DateHelper.GetDateNowString_Sortable();
                    UpadateKeyValue(existingKeyValue);
                }
            }
            else
            {
                UpadateKeyValue(keyValue);
            }
        }

        private void UpadateKeyValue(KeyValue keyValue)
        {
            context.KeyValues.Attach(keyValue);
            context.Entry(keyValue).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void SavePriceCode(KeyValue keyValue)
        {
            PriceCode.CodeLoadedFromDB = false;
            SaveKeyalue(keyValue);
        }

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
            Product existingProduct = context.Products
                .Where(x => (x.Id != product.Id && x.Name.Replace(" ", "").ToLower() == product.Name.Replace(" ", "").ToLower())) // Validate by removing spacen in btween words
                .FirstOrDefault();
            if (existingProduct == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<ProductReport> GetProductListForAdmin(string productName)
        {
            productName = productName.Trim().ToLower();

            var groupQuery = from DBB in context.DealerBillBreakups
                             group DBB by new { DBB.ProductId } into groupedBillBreakup
                             select new
                             {
                                 DBBGroupKey = groupedBillBreakup.Key,
                                 AvaiableQuantity = groupedBillBreakup.Sum(x => x.AvailableQuantity)
                             };
            //var list1 = groupQuery.ToList();

            var exactMatchQuery = from P in context.Products.Where(x => productName == "" || x.Name.ToLower().Contains(productName))
                                  from grp in groupQuery.Where(g => g.DBBGroupKey.ProductId == P.Id).DefaultIfEmpty()// Left join Product on GroupedQuery
                                  select new ProductReport
                                  {
                                      Id = P.Id,
                                      ProductName = P.Name,
                                      AvailableQuantity = grp == null ? 0 : grp.AvaiableQuantity,
                                      LowerLimit = P.LowerLimit,
                                      UpperLimit = P.UpperLimit
                                  };
            List<ProductReport> exactMatchProductList = exactMatchQuery.OrderBy(x => x.ProductName).ToList();

            if (productName.Trim().Split(' ').Length == 1)
            {
                BaseEntity.ResetRowNumberInList(exactMatchProductList);
                return exactMatchProductList.Take(50).ToList();
            }

            // Search each word of product name
            string[] splittedProductNames = productName.Split(' ');
            var splitWordMatchQuery = from P in context.Products.Where(p => splittedProductNames.Any(x => p.Name.ToLower().Contains(x)))
                                      from grp in groupQuery.Where(g => g.DBBGroupKey.ProductId == P.Id).DefaultIfEmpty()// Left join Product on GroupedQuery
                                      select new ProductReport
                                      {
                                          Id = P.Id,
                                          ProductName = P.Name,
                                          AvailableQuantity = grp == null ? 0 : grp.AvaiableQuantity,
                                          LowerLimit = P.LowerLimit,
                                          UpperLimit = P.UpperLimit
                                      };
            List<ProductReport> splittedNameProductList = splitWordMatchQuery.OrderBy(x => x.ProductName).ToList();

            List<ProductReport> mergedList = exactMatchProductList.Union(splittedNameProductList, new ProductReportComparer()).ToList(); // merge by removing duplicate
            BaseEntity.ResetRowNumberInList(mergedList);
            return mergedList.Take(100).ToList();
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
                SaveDealer(new Dealer() { Name = PersonBase.DEFAULT_NAME, Address = "" });
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
            return context.Dealers.Where(x => x.Name.ToLower() == PersonBase.DEFAULT_NAME.ToLower()).FirstOrDefault();
        }

        public List<Dealer> GetDealerList()
        {
            List<Dealer> dealerList = context.Dealers.OrderBy(x => x.Name).ToList();
            BaseEntity.ResetRowNumberInList(dealerList);
            return dealerList;
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
            PersonBase existingCustomer = context.Customers
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
                SaveCustomer(new Customer() { Name = PersonBase.DEFAULT_NAME, Address = "" });
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
            return context.Customers.Where(x => x.Name.ToLower() == PersonBase.DEFAULT_NAME.ToLower()).FirstOrDefault();
        }

        public List<Customer> GetCustomerList()
        {
            List<Customer> customerList = context.Customers.OrderBy(x => x.Name).ToList();
            BaseEntity.ResetRowNumberInList(customerList);
            return customerList;
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

        public BillReport GetDealerBillReport(int billId)
        {
            var billBreakupGroped = from DBB in context.DealerBillBreakups.Where(x => x.DealerBillId == billId)
                                    group DBB by DBB.DealerBillId into g
                                    select new
                                    {
                                        DealerBillId = g.Key,
                                        DBBCount = g.Count(),
                                        DBBAmount = g.Sum(x => x.TotalAmount)
                                    };
            //var list1 = billBreakupGroped.ToList(); // Always 1 record

            var joinQuery = from D in context.Dealers
                            from DB in context.DealerBills.Where(x => x.Id == billId && x.DealerId == D.Id)
                            from DBB in billBreakupGroped.Where(g => g.DealerBillId == DB.Id).DefaultIfEmpty()
                            select new BillReport
                            {
                                Id = DB.Id,
                                PersonName = D.Name,
                                BillDate = DB.BillDate,
                                TotalAmount = DB.TotalAmount,
                                BreakupCount = DBB == null ? 0 : DBB.DBBCount,
                                BreakupSum = DBB == null ? 0 : DBB.DBBAmount,
                                Remarks = DB.Remarks
                            };
            //var list2 = joinQuery.ToList(); // Count should be total breakup of the Bill

            return joinQuery.FirstOrDefault();
        }

        public List<BillReport> GetDealerBillReportList(int dealerId)
        {
            var billBreakupGroped = from DB in context.DealerBills.Where(x => x.DealerId == dealerId)
                                    from DBB in context.DealerBillBreakups.Where(x => x.DealerBillId == DB.Id) // Inner Join
                                    group DBB by DBB.DealerBillId into g
                                    select new
                                    {
                                        DealerBillId = g.Key,
                                        DBBCount = g.Count(),
                                        DBBAmount = g.Sum(x => x.TotalAmount)
                                    };
            //var list1 = billBreakupGroped.ToList();

            var joinQuery = from D in context.Dealers.Where(x => x.Id == dealerId)
                            from DB in context.DealerBills.Where(x => x.DealerId == D.Id) // Inner Join
                            from DBB in billBreakupGroped.Where(g => g.DealerBillId == DB.Id).DefaultIfEmpty() // Left join
                            select new BillReport
                            {
                                Id = DB.Id,
                                PersonName = D.Name,
                                BillDate = DB.BillDate,
                                TotalAmount = DB.TotalAmount,
                                BreakupCount = DBB == null ? 0 : DBB.DBBCount,
                                BreakupSum = DBB == null ? 0 : DBB.DBBAmount,
                                Remarks = DB.Remarks
                            };

            List<BillReport> list = joinQuery.OrderByDescending(x => x.BillDate).ToList(); // Count should be same as list 1
            BaseEntity.ResetRowNumberInList(list);
            return list;
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
            List<DealerBillBreakup> dealerBillBreakupList = context.DealerBillBreakups.Include(x => x.Product).Where(x => x.DealerBillId == billId).OrderByDescending(x => x.EntryDate).ToList();
            BaseEntity.ResetRowNumberInList(dealerBillBreakupList);
            return dealerBillBreakupList;
        }

        public DealerBillBreakup GetDealerBillBreakup(int billId)
        {
            return context.DealerBillBreakups.Include(x => x.Product).Where(x => x.Id == billId).FirstOrDefault();
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

        public List<BillReport> GetCustomerBillList(int customerId)
        {
            var billBreakupGroped = from CB in context.CustomerBills.Where(x => x.CustomerId == customerId)
                                    from CBB in context.CustomerBillBreakups.Where(x => x.CustomerBillId == CB.Id) // Inner Join
                                    group CBB by CBB.CustomerBillId into g
                                    select new
                                    {
                                        DealerBillId = g.Key,
                                        CBBCount = g.Count(),
                                        CBBAmount = g.Sum(x => x.TotalAmount)
                                    };
            var list1 = billBreakupGroped.ToList();

            var joinQuery = from C in context.Customers.Where(x => x.Id == customerId)
                            from CB in context.CustomerBills.Where(x => x.CustomerId == C.Id) // Inner Join
                            from CBB in billBreakupGroped.Where(g => g.DealerBillId == CB.Id).DefaultIfEmpty() // Left join
                            select new BillReport
                            {
                                Id = CB.Id,
                                PersonName = C.Name,
                                BillDate = CB.BillDate,
                                TotalAmount = CB.TotalAmount,
                                BreakupCount = CBB == null ? 0 : CBB.CBBCount,
                                BreakupSum = CBB == null ? 0 : CBB.CBBAmount,
                                Remarks = CB.Remarks
                            };

            List<BillReport> customerBillList = joinQuery.OrderByDescending(x => x.BillDate).ToList(); // Count should be same as list1

            BaseEntity.ResetRowNumberInList(customerBillList);
            return customerBillList;
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

        public List<CustomerBillBreakupReport> GetCustomerBillBreakupList(int billId)
        {
            List<CustomerBillBreakupReport> customerBillBreakupReportList =
                (from CBB in context.CustomerBillBreakups
                 join P in context.Products on CBB.ProductId equals P.Id
                 where CBB.CustomerBillId == billId
                 select new CustomerBillBreakupReport
                 {
                     productName = P.Name,
                     TotalAmount = CBB.TotalAmount,
                     TotalQuantity = CBB.TotalQuantity,
                     UnitPrice = CBB.UnitPrice
                 }).ToList();
            BaseEntity.ResetRowNumberInList(customerBillBreakupReportList);
            return customerBillBreakupReportList;
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

                                                         }).OrderBy(x => x.ProductName).Take(50).ToList();

            if (productName.Trim().Split(' ').Length == 1)
            {
                BaseEntity.ResetRowNumberInList(exactMatchProductList);
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

                                                           }).OrderBy(x => x.ProductName).Take(50).ToList();

            var mergedList = exactMatchProductList.Union(splittedNameProductList, new Comparer()).ToList(); // merge by removing duplicate
            BaseEntity.ResetRowNumberInList(mergedList);
            return mergedList;
        }

        #region Report
        public List<ProductReport> GetProductReport(string productName)
        {
            List<ProductReport> productReportList = new List<ProductReport>();

            var groupQuery = from DBB in context.DealerBillBreakups.Where(x => x.AvailableQuantity > 0) // do not fetch bills if products already sold
                             group DBB by new { DBB.ProductId, DBB.UnitPrice } into groupedBillBreakup
                             select new
                             {
                                 DBBGroupKey = groupedBillBreakup.Key,
                                 AvaiableQuantity = groupedBillBreakup.Sum(x => x.AvailableQuantity),
                                 TotalQuantity = groupedBillBreakup.Sum(x => x.TotalQuantity)
                             };
            var list1 = groupQuery.ToList();

            var joinQuery = from P in context.Products
                            from grp in groupQuery.Where(g => g.DBBGroupKey.ProductId == P.Id).DefaultIfEmpty()// Left join Product on GroupedQuery
                            select new ProductReport
                            {
                                Id = P.Id,
                                ProductName = P.Name,
                                TotalQuantity = grp == null ? 0 : grp.TotalQuantity,
                                AvailableQuantity = grp == null ? 0 : grp.AvaiableQuantity,
                                UnitPrice = grp == null ? 0 : grp.DBBGroupKey.UnitPrice
                            };
            productReportList = joinQuery.ToList();
            BaseEntity.ResetRowNumberInList(productReportList);
            return productReportList;
        }
        #endregion
    }


}
