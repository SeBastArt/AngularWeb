using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    public class ArticlePriceListOut : ArticlePriceList
    {
        [Column("priority")]
        public long Priority { get; set; }

        [Column("reordertime")]
        public DateTime ReorderTime { get; set; }
    }
}
