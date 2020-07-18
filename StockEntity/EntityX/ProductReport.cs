﻿using StockEntity.Entity;

namespace StockEntity.EntityX
{
    public class ProductReport:BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int AvailableQuantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
