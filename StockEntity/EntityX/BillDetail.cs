using StockEntity.Helper;
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

        public void ValidateBillDetail()
        {
            if (BillId == 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Could not found Bill Id";
            }
            else if (ProductId ==0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Could not found Product Id";
            }
        }
    }
}
