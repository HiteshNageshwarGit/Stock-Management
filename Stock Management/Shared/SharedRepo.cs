using StockEntity;

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
        public static DBRepository DBRepo { get; private set; }           
        #endregion        

        public static void InitializeSession()
        {
            DBRepo = new DBRepository();
            DBRepo.GetProductReport();
        }

        //public static void InsertDummyData()
        //{
        //    for (int i = 51; i < 100; i++)
        //    {
        //        ProductRepo.SaveProduct(new Product()
        //        {
        //            Name = "Product Number 100" + i,
        //            Code = "PROD" + i,
        //            Remarks = "Remarks are auto update for " + i
        //        });
        //    }

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Dealer dealer = new Dealer()
        //        {
        //            Name = "Dealer Number 200" + i,
        //            Address = "Dealer Address " + i,
        //            Mobile = "987456321" + i
        //        };
        //        ProductRepo.SaveDealer(dealer);
        //        for (int j = 0; j < 10; j++)
        //        {
        //            DealerBill dealerBill = new DealerBill()
        //            {
        //                DealerId = dealer.Id,
        //                BillDate = DateHelper.GetTodayDateString(),
        //                TotalAmount = 500 + (3 * new Random().Next(1, 110)),
        //                EntryDate = DateHelper.GetTodayDateString(),
        //                Remarks = "Dealer bill remark " + i
        //            };
        //            DealerBillRepo.Add(dealerBill);

        //            for (int k = 0; k < 10; k++)
        //            {
        //                try
        //                {

        //                    List<Product> list = ProductRepo.GetProductListForAdmin("");

        //                    Product product = list.Find(x => x.Id == new Random().Next(list.First().Id, list.Last().Id));
        //                    if (product == null) { continue; }
        //                    DealerBillBreakup dealerBillBreakup = new DealerBillBreakup()
        //                    {
        //                        DealerBillId = dealerBill.Id,
        //                        TotalAmount = 50 + (2 * new Random().Next(1, 110)),
        //                        EntryDate = DateHelper.GetTodayDateString(),
        //                        ProductId = product.Id,
        //                        TotalBoxes = 1,
        //                        TotalQuantity = 10,
        //                        UnitPrice = 50 + (3 * i),
        //                        QuantityInBox = 1,
        //                        Remarks = "Deaelr bill breakup remarks " + i
        //                    };
        //                    DealerBillBreakupRepo.Add(dealerBillBreakup);
        //                }
        //                catch (Exception ed)
        //                { }
        //            }
        //        }
        //    }
        //}
    }
}
