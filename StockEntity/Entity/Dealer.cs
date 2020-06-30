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
            EntityState.State = ValidationState.SUCCESS;
            if (string.IsNullOrWhiteSpace(this.Name))
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage = "Name is a " + Message.Required;
            }
            else if (Name.Length > 50)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage = Message.MaxLength50;
            }
        }
    }
}
