using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public class Bill : BaseEntity
    {
        //public int Id { get; set; }
        public int DealerId { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillEntryDate { get; set; }
        public float TotalAmount { get; set; }
        public string Remarks { get; set; }
    }
}
