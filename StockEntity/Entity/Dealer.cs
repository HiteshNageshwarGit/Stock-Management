using StockEntity.Helper;
using System;

namespace StockEntity.Entity
{
    public partial class Dealer : BaseEntity
    {
        #region Entity Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        #endregion
        public override string ToString()
        {
            return Name;
        }
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
