using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public partial class Dealer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public void ValidateDealer()
        {
            this.EntityState.State = ValidationState.SUCCESS;
            if (String.IsNullOrWhiteSpace(this.Name))
            {
                this.EntityState.State = ValidationState.ERROR;
                this.EntityState.StateMessage = Message.Required;
            }
            else if (this.Name.Length > 50)
            {
                this.EntityState.State = ValidationState.ERROR;
                this.EntityState.StateMessage = Message.MaxLength50;
            }
        }
    }
}
