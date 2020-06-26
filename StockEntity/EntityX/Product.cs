using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public partial class Product
    {
        public override string ToString()
        {
            return Name;
        }

        public void ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage = Message.Required;
            }
            else if (Name.Length > 50)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage = Message.MaxLength50;
            }
        }
    }
}
