using StockEntity.Helper;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockEntity.Entity
{
    public partial class Bill : BaseEntity
    {
        #region Entity Properties           
        public string BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        #endregion


        public void Validate()
        {            
            if (TotalAmount <= 0)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Bill amount should be greate than 0";
            }           
        }

    }
}
