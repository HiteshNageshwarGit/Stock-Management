using System;

namespace StockEntity.Entity
{
    public class History : BaseEntity
    {
        #region Entity Properties
        public string RecordName { get; set; }
        public string HistoryRemark { get; set; }
        public DateTime EntryDate { get; set; }
        #endregion
    }
}
