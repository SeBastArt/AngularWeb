using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities.Address
{
    [Table("address_address")]
    public class Address : BaseEntity
    {
        [Column("id")]
        public long AddressId { get; set; }

        [Column("fk_parent_address")]
        public virtual long? ParentId { get; set; }

        public virtual Address Parent { get; set; }

        [Column("fk_address_country")]
        public virtual long? AddressCountryId { get; set; }

        public virtual AddressCountry AddressCountry { get; set; }
        
        [Column("fk_logo")]
        public virtual long? FAGBinaryId { get; set; }

        public virtual FAGBinary Logo { get; set; }

        [Column("fk_address_company_type")]
        public virtual long? AddressCompanyTypeId { get; set; }

        public virtual AddressCompanyType AddressCompanyType { get; set; }

        [Column("name", TypeName = "varchar(max)")]
        public virtual string Name { get; set; }

        [Column("addition", TypeName = "varchar(max)")]
        public virtual string Addition { get; set; }

        [Column("addition2", TypeName = "varchar(max)")]
        public virtual string Addition2 { get; set; }

        [Column("street", TypeName = "varchar(max)")]
        public virtual string Street { get; set; }

        [Column("postcode", TypeName = "varchar(max)")]
        public virtual string PostCode { get; set; }

        [Column("city", TypeName = "varchar(max)")]
        public virtual string City { get; set; }

        [Column("email", TypeName = "varchar(max)")]
        public virtual string Email { get; set; }

        [Column("phone", TypeName = "varchar(max)")]
        public virtual string Phone { get; set; }

        [Column("fax", TypeName = "varchar(max)")]
        public virtual string Fax { get; set; }

        [Column("vat_id_no", TypeName = "varchar(max)")]
        public virtual string VatId { get; set; }

        [Column("timezone", TypeName = "varchar(max)")]
        public virtual string TimeZone { get; set; }

        public ICollection<AddressPersonRelation> AddressPersonRelations { get; set; }
    }
}
