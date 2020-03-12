using System.ComponentModel.DataAnnotations.Schema;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AngularWeb.Entities
{
    [Table("address_person_relation")]
    public class AddressPersonRelation : BaseEntity
    {
        [Column("id")]
        public long AddressPersonRelationId { get; set; }

        [Column("fk_address")]
        public long AddressId { get; set; }
        public Address Address { get; set; }

        [Column("fk_person")]
        public long AddressPersonId { get; set; }
        public AddressPerson AddressPerson { get; set; }
    }

    public class AddressPersonRelationConfiguration : IEntityTypeConfiguration<AddressPersonRelation>
    {
        public void Configure(EntityTypeBuilder<AddressPersonRelation> builder)
        {
         
            //

        }
    }
}
