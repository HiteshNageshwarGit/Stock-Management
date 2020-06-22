using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public partial class Bill : BaseEntity
    {
        public int DealerId { get; set; }
        public string BillDate { get; set; }
        public string BillEntryDate { get; set; }
        public float TotalAmount { get; set; }
        public string Remarks { get; set; }
        
    }
}
