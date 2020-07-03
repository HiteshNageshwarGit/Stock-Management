using StockEntity.Helper;

namespace StockEntity.Entity
{
    public class Person : BaseEntity
    {
        public const int DEALER = 1;
        public const int CUSTOMER = 2;

        #region Entity Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        #endregion

        public void Validate()
        {
            EntityState.State = ValidationState.SUCCESS;
            if (string.IsNullOrWhiteSpace(Name))
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
        public override string ToString()
        {
            return Name;
        }
    }
}