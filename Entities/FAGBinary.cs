using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("fag_binary")]
    public class FAGBinary : BaseEntity
    {
        [Column("id")]
        public long FAGBinaryId { get; set; }

        [JsonIgnore]
        [Column("fk_id")]
        public long FKId { get; set; }

        [Column("file_name", TypeName = "varchar(max)")]
        public string FileName { get; set; }

        [Column("data", TypeName = "varbinary(max)")]
        public byte[] Data { get; set; }
    }
}