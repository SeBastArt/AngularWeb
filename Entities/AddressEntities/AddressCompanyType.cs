using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("address_company_type")]
    public class AddressCompanyType : BaseEntity
    {
        [Column("id")]
        public long AddressCompanyTypeId { get; set; }

        [Column("name", TypeName = "varchar(max)")]
        public string Name { get; set; }

        [Column("type")]
        public int Type { get; set; }
    }
}
