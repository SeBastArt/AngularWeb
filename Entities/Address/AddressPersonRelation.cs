using System.ComponentModel.DataAnnotations.Schema;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AngularWeb.Entities.Address
{
    [Table("address_person_relation")]
    public class AddressPersonRelation : BaseEntity
    {
        public long AddressPersonRelationId { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }
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
