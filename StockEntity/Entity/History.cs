using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public class History : BaseEntity
    {
        //public int Id { get; set; }
        public string RecordName { get; set; }
        public string HistoryRemark { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
