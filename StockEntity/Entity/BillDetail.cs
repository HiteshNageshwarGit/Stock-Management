using StockEntity.Helper;
using System.Text;

namespace StockEntity.Entity
{
    public partial class BillBreakup : BaseEntity
    {
        #region Entity Properties
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public decimal TotalAmount { get; set; }
        public int QuantityInBox { get; set; }
        public int TotalBoxes { get; set; }
        public int TotalQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string EntryDate { get; set; }
        #endregion

        public Bill Bill { get; set; }
        public Product Product { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder("Rs. " + TotalAmount.ToString());
            if (Product != null)
            {
                str.Append(" - " + Product.ToString());
            }
            if (Bill != null)
            {
                str.Append(" - " + Bill.ToString());
            }
            return str.ToString();

        }

        public void ValidateBillBreakup()
        {
            if (BillId == 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Could not found Bill Id";
            }
            else if (ProductId == 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Could not found Product Id";
            }
        }
    }
}
