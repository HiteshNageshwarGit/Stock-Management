using System.ComponentModel.DataAnnotations.Schema;

namespace StockEntity.Entity
{
    public partial class ProductProperty : BaseEntity
    {
        #region Entity Properties
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        #endregion

        [NotMapped]
        public new string Remarks { get; set; } // Remarks in not required in DB, so do not map in entity framework
    }
}
