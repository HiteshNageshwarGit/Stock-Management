using StockEntity.Helper;
using System;

namespace StockEntity.Entity
{
    public partial class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Color { get; set; }

        public void ValidateProductMaster()
        {
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
