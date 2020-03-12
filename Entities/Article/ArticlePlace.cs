using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AngularWeb.Entities;

namespace AngularWeb.Entities
{
    [Table("article_places")]
    public class ArticlePlace :BaseEntity
    {
        [Column("id")]
        public long ArticlePlaceId { get; set; }

        [JsonIgnore]
        [Column("fk_address")]
        public long AddressId { get; set; }

        [Column("location", TypeName = "varchar(max)")]
        public Address Address { get; set; }

        [Column("reserved_qty", TypeName = "decimal (38,20)")]
        public decimal ReservedQty { get; set; }

        [Column("minimum_qty", TypeName = "decimal (38,20)")]
        public decimal MinimumQty { get; set; }

        [Column("opo_qty", TypeName = "decimal (38,20)")]
        public decimal OpoQty { get; set; }
    }
}
