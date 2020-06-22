using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public partial class Bill
    {
        public Dealer Dealer { get; set; }
    }
}
