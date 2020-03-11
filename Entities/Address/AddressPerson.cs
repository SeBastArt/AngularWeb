using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities.Address
{
    [Table("address_person")]
    public class AddressPerson : BaseEntity
    {
        [Column("id")]
        public long AddressPersonId { get; set; }


        [Column("lastname", TypeName = "varchar(max)")]
        public virtual string LastName { get; set; }

        [Column("firstname", TypeName = "varchar(max)")]
        public virtual string FirstName { get; set; }

        [Column("sex", TypeName = "varchar(max)")]
        public virtual string Sex { get; set; }

        [Column("department", TypeName = "varchar(max)")]
        public virtual string Department { get; set; }

        [Column("phone_office", TypeName = "varchar(max)")]
        public virtual string PhoneOffice { get; set; }

        [Column("phone_private", TypeName = "varchar(max)")]
        public virtual string PhonePrivate { get; set; }

        [Column("email", TypeName = "varchar(max)")]
        public virtual string Email { get; set; }

        public virtual long? PictureId { get; set; }

        [Column("fk_picture", TypeName = "varchar(max)")]
        public virtual FAGBinary Picture { get; set; }

        public ICollection<AddressPersonRelation> AddressPersonRelations { get; set; }
    }
}
