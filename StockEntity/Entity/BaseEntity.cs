using StockEntity.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Remarks { get; set; }

        [NotMapped]
        public ValidationState EntityState { get; set; }

        public BaseEntity()
        {
            this.EntityState = new ValidationState();
        }
    }
}
