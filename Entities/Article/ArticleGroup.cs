using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AngularWeb.Entities
{
    [Table("article_group")]
    public class ArticleGroup : BaseEntity
    {
        [Column("id")]
        public long ArticleGroupId { get; set; }

        [Column("name")]
        public virtual string Name { get; set; }
    }
}
