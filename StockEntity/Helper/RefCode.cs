using System.Linq;

namespace StockEntity.Helper
{
    class RefCode
    {
        //var query = (
        //               from users in context.Products
        //               from mappings in context.DealerBillBreakups.Where(mapping => mapping.ProductId == users.Id).DefaultIfEmpty()
        //               group mappings by users.Name into g
        //               select new ProductReport
        //               {
        //                   ProductName = g.Key,
        //                   AvailableQuantity = g.Sum(mappings => mappings == null ? 0 : mappings.AvailableQuantity),

        //               }).ToList();

        //var dd = from mappings in context.DealerBillBreakups
        //         group mappings by mappings.ProductId into g
        //         select new ProductReport
        //         {
        //             Id = g.Key,
        //             AvailableQuantity = g.Sum(mappings => mappings == null ? 0 : mappings.AvailableQuantity)
        //         };

        //var dddd = (from users in context.Products
        //            from aa in dd.Where(x => x.Id == users.Id).DefaultIfEmpty()
        //            select new
        //            {
        //                Name = users.Name,
        //                qua = aa == null ? 0 : aa.AvailableQuantity
        //            }).ToList();





        //var terwe = (
        //                     from b in context.Products
        //                     join oi in context.DealerBillBreakups on b.Id equals oi.ProductId
        //                     group oi by b.Name into g
        //                     select new
        //                     {
        //                         Name = g.Key,
        //                         Sum = g.Sum(oi => oi.AvailableQuantity),
        //                     }).ToList();
    }
}
