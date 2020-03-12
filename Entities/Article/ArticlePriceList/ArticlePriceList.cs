using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AngularWeb.Entities
{
    [Table("article_pricelist")]
    public abstract class ArticlePriceList : BaseEntity
    {
        [Column("id")]
        public long ArticlePriceListId { get; set; }

        [Column("scale_unit_qty")]
        public int ScaleUnitQty { get; set; }

        [Column("scale_unit_type")]
        public int ScaleUnitType { get; set; }

        [Column("unit_order")]
        public int UnitOrder { get; set; }

        [Column("min_order_qty", TypeName = "decimal (38,20)")]
        public decimal MinOrderQty { get; set; }       

        [Column("is_multiply_order_qty")]
        public bool IsMultipleOrderQty { get; set; }

        public IEnumerable<ArticleRange> PriceRanges { get; set; } = new List<ArticleRange>();

        [JsonIgnore]
        [Column("fk_article")]
        public long ArticleId { get; set; }

        public virtual Article Article { get; set; }
    }
}
