using System.ComponentModel.DataAnnotations.Schema;

namespace StockEntity.Entity
{
    public class KeyValue : BaseEntity
    {
        #region Entity Properties  
        public string Key { get; set; }
        public string Value { get; set; }
        #endregion
        [NotMapped]
        public new string Remarks { get; set; } // Remarks in not required in DB, so do not map in entity framework
    }
}
