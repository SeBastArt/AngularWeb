using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("article_article_text")]
    public class ArticleText
    {
        [Column("id")]
        public long ArticleTextId { get; set; }

        [Column("language_iso_3cc", TypeName = "varchar(3)")]
        public string LanguageIso3cc { get; set; }

        [Column("language_iso_2cc", TypeName = "varchar(2)")]
        public string LanguageIso2cc { get; set; }
    }
}
