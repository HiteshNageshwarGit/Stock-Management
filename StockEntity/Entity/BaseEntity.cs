using StockEntity.Helper;
using System.Collections.Generic;
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
        public int SNo { get; set; } // Set explicitly when list created
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

        public static void ResetRowNumberInList<T>(List<T> list)
        {
            int count = 0;
            foreach (T item in list)
            {
                try
                {
                    item.GetType().GetProperty("SNo").SetValue(item, ++count);
                }
                catch
                {
                }
            }
        }
    }
}
