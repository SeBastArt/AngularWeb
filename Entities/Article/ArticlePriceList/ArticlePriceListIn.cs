using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    public class ArticlePriceListIn : ArticlePriceList
    {
        [Column("valid_from")]
        public DateTime ValidFrom { get; set; }

        [Column("valid_to")]
        public DateTime Validto { get; set; }
    }
}
