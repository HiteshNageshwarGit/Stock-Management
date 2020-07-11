using StockEntity.Helper;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockEntity.Entity
{
    public class BaseEntity
    {
        #region Entity Properties
        public int Id { get; set; }
        public string Remarks { get; set; }
        public string TimeStamp { get; set; }
        #endregion

        [NotMapped]
        public ValidationState EntityState { get; set; }

        public BaseEntity()
        {
            EntityState = new ValidationState();
        }
        public void ResetValidationError()
        {
            EntityState.State = ValidationState.SUCCESS;
            EntityState.StateMessage = "";
        }
    }
}
