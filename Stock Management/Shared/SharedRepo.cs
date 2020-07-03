﻿using StockEntity.Entity;
using StockEntity.Helper;
using StockEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stock_Management.Shared
{
    public class SharedRepo
    {
        public const string DBVersion = "DBVersion";
        public const string DBBackupDir = "DBBackupDir";
        public const string AdminUser = "AdminUser";
        public const string AdminPassword = "AdminPassword";
        public const string GeneralUser = "GeneralUser";
        public static string UserRole { get; set; }
        #region Properties

        public static KeyValueRepository keyValueRepo { get; private set; }
        public static ProductRepository ProductRepo { get; private set; }
        public static DealerRepository DealerRepo { get; private set; }
        public static CustomerRepository CustomerRepo { get; private set; }
        public static DealerBillRepository DealerBillRepo { get; private set; }
        public static DealerBillBreakupRepository DealerBillBreakupRepo { get; private set; }
        #endregion        

        public static void InitializeSession()
        {
            keyValueRepo = new KeyValueRepository();
            DealerRepo = new DealerRepository();
            CustomerRepo = new CustomerRepository();
            DealerBillRepo = new DealerBillRepository();
            DealerBillBreakupRepo = new DealerBillBreakupRepository();
            ProductRepo = new ProductRepository();
        }

        public static void InsertDummyData()
        {
            for (int i = 51; i < 100; i++)
            {
                ProductRepo.Add(new Product()
                {
                    Name = "Product Number " + i,
                    Code = "PROD" + i,
                    Remarks = "Remarks are auto update for " + i
                });
            }

            for (int i = 0; i < 5; i++)
            {
                Dealer dealer = new Dealer()
                {
                    Name = "Dealer Number " + i,
                    Address = "Dealer Address " + i,
                    Mobile = "987456321" + i
                };
                DealerRepo.Add(dealer);
                for (int j = 0; j < 10; j++)
                {
                    DealerBill dealerBill = new DealerBill()
                    {
                        DealerId = dealer.Id,
                        BillDate = DateHelper.GetTodayDateString(),
                        TotalAmount = 500 + (3 * new Random().Next(1, 10)),
                        EntryDate = DateHelper.GetTodayDateString(),
                        Remarks = "Dealer bill remark " + i
                    };
                    DealerBillRepo.Add(dealerBill);

                    for (int k = 0; k < 10; k++)
                    {
                        try
                        {

                            List<Product> list = ProductRepo.GetProductListForAdmin("");

                            Product product = list.Find(x => x.Id == new Random().Next(list.First().Id, list.Last().Id));
                            if (product == null) { continue; }
                            DealerBillBreakup dealerBillBreakup = new DealerBillBreakup()
                            {
                                DealerBillId = dealerBill.Id,
                                TotalAmount = 50 + (2 * new Random().Next(1, 10)),
                                EntryDate = DateHelper.GetTodayDateString(),
                                ProductId = product.Id,
                                TotalBoxes = 1,
                                TotalQuantity = 1,
                                UnitPrice = 50 + (3 * i),
                                QuantityInBox = 1,
                                Remarks = "Deaelr bill breakup remarks " + i
                            };
                            DealerBillBreakupRepo.Add(dealerBillBreakup);
                        }
                        catch (Exception ed)
                        { }
                    }
                }
            }
        }
    }
}
