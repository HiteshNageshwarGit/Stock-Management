using StockEntity.Helper;
using System.Text;

namespace StockEntity.Entity
{
    public partial class Product : BaseEntity
    {
        #region Entity Properties
        public string Name { get; set; }
        public string Code { get; set; }
        public string Color { get; set; }
        #endregion

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(Name);
            if (!string.IsNullOrWhiteSpace(Code))
            {
                str.Append(" - " + Code);
            }
            if (!string.IsNullOrWhiteSpace(Color))
            {
                str.Append(" - " + Color);
            }
            return str.ToString();
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
