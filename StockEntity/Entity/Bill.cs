﻿using System.Collections.Generic;
using System.Text;

namespace StockEntity.Entity
{
    public partial class Bill : BaseEntity
    {
        #region Entity Properties
        public int DealerId { get; set; }
        public string BillDate { get; set; }
        public string EntryDate { get; set; }
        public decimal TotalAmount { get; set; }
        #endregion

        public Dealer Dealer { get; set; }

        public ICollection<BillBreakup> BillBreakupList { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(BillDate + " ( Rs. " + TotalAmount + " )");
            if (Dealer != null)
            {
                str.Append(" - " + Dealer.ToString());
            }
            return str.ToString();
        }
    }
}
