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
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
        #endregion

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(Name);
            return str.ToString();
        }

        public void ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage = "Name is required";
            }
            else if (Name.Length > 50)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage = "Max 50 charectors allowed for Name";
            }

            if (LowerLimit != 0  || UpperLimit != 0)// Validate RAG if value provided for any one
            {
                if (LowerLimit == 0 || UpperLimit == 0)
                {
                    EntityState.State = ValidationState.ERROR;
                    EntityState.StateMessage = "All limit values must be greater than ZERO";
                }
                else if (LowerLimit > UpperLimit)
                {
                    EntityState.State = ValidationState.ERROR;
                    EntityState.StateMessage = "Lower limit must be less than Upper limit";
                }
            }
        }
    }
}
