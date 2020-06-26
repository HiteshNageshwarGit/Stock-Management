using StockEntity.Helper;
using System;

namespace StockEntity.Entity
{
    public partial class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Color { get; set; }        
    }
}
