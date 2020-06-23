using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public partial class BillDetail
    {
        public Bill Bill { get; set; }
        public Product Product { get; set; }
    }
}
