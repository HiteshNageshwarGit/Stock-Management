using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public class BillDetail : BaseEntity
    {
        //public int Id { get; set; }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public float TotalAmount { get; set; }
        public int QuantityInBox { get; set; }
        public int TotalBoxes { get; set; }
        public int TotalQuantity { get; set; }
    }
}
