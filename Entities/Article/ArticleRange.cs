using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("article_range")]
    public class ArticleRange : BaseEntity
    {
        [Column("id")]
        public long ArticleRangeId { get; set; }

        [Column("quantity", TypeName = "decimal (38,20)")]
        public decimal Quantity { get; set; }

        [Column("netprice", TypeName = "decimal (38,20)")]
        public decimal NetPrice { get; set; }

        [Column("discount", TypeName = "decimal (38,20)")]
        public decimal Discount { get; set; }

        [Column("addition", TypeName = "decimal (38,20)")]
        public decimal Addition { get; set; }

        [Column("price", TypeName = "decimal (38,20)")]
        public decimal Price { get; set; }

        [JsonIgnore]
        [Column("fk_pricelist")]
        public long ArticlePriceListId { get; set; }

        public ArticlePriceList ArticlePriceList { get; set; }
    }
}
