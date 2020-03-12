using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AngularWeb.Entities
{
    [Table("article_type")]
    public class ArticleType : BaseEntity
    {
        [Column("id")]
        public long ArticleTypeId { get; set; }

        [Column("name")]
        public virtual string Name { get; set; }

        [Column("nature_type")]
        public virtual string NatureType { get; set; }
    }
}
