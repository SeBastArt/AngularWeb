using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularWeb.Entities
{
    [Table("address_country")]
    public class AddressCountry : BaseEntity
    {
        [Column("id")]
        public long AddressCountryId { get; set; }
        
        [Column("iso_3cc", TypeName = "varchar(3)")]
        public string Iso3cc { get; set; }
        
        [Column("iso_2cc", TypeName = "varchar(2)")]
        public string Iso2cc { get; set; }
        
        [Column("iso_numerical")]
        public int IsoNumerical { get; set; }
        
        [Column("economic_area")]
        public int EconomicArea { get; set; }
        
        [Column("name", TypeName = "varchar(max)")]
        public string Name { get; set; }
        
        [Column("address_type")]
        public int AdressType { get; set; }
        
        [Column("address_text_document_script", TypeName = "varchar(max)")]
        public string AddressTextDocumentScript { get; set; }
        
        [Column("address_text_delivery_script", TypeName = "varchar(max)")]
        public string AddressTextDeliveryScript { get; set; }
        
        [Column("address_text_invoice_script", TypeName = "varchar(max)")]
        public string AddressTextInvoiceScript { get; set; }

    }
}
