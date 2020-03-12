using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("article_inventory")]
    public class ArticleInventory : BaseEntity
    {
        [Column("id")]
        public long ArticleInventoryId { get; set; }

        public long ArticlePlaceId { get; set; }

        [Column("fk_place")]
        public ArticlePlace ArticlePlace { get; set; }

        [Column("info_1")]
        public string Info1 { get; set; }

        [Column("info_1_rtf")]
        public string Info1RTF { get; set; }

        [Column("info_2")]
        public string Info2 { get; set; }

        [Column("info_2_rtf")]
        public string Info2RTF { get; set; }

        [Column("info_3")]
        public string Info3 { get; set; }

        [Column("info_3_rtf")]
        public string Info3RTF { get; set; }

        [Column("info_4")]
        public string Info4 { get; set; }

        [Column("info_4_rtf")]
        public string Info4RTF { get; set; }

        [Column("info_5")]
        public string Info5 { get; set; }

        [Column("info_5_rtf")]
        public string Info5RTF { get; set; }

        [Column("fk_article")]
        public long ArticleId { get; set; }

        public virtual Article Article { get; set; }
    }
}
