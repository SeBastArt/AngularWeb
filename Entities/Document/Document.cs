using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("document_document")]
    public class Document : BaseEntity
    {
        [Column("id")]
        public long DocumentId { get; set; }

        public long DocumentPersonId { get; set; }

        [Column("fk_person")]
        public virtual AddressPerson DocumentPerson { get; set; }

        public long DocumentAddressId { get; set; }

        [Column("fk_address")]
        public virtual Address DocumentAddress { get; set; }

        public long DeliveryPersonId { get; set; }

        [Column("fk_delivery_person")]
        public virtual AddressPerson DeliveryPerson { get; set; }

        public long DeliveryAddressId { get; set; }

        [Column("fk_delivery_address")]
        public virtual Address DeliveryAddress { get; set; }

        public long InvoicePersonId { get; set; }

        [Column("fk_invoice_person")]
        public virtual AddressPerson InvoicePerson { get; set; }

        public long InvoiceAddressId { get; set; }

        [Column("fk_invoice_address")]
        public virtual Address InvoiceAddress { get; set; }

        [Column("address_text_document", TypeName = "varchar(max)")]
        public string AddressTextDocument { get; set; }

        [Column("address_text_delivery", TypeName = "varchar(max)")]
        public string AddressTextDelivery { get; set; }

        [Column("address_text_invoice", TypeName = "varchar(max)")]
        public string AddressTextInvoice { get; set; }

        [Column("number", TypeName = "varchar(max)")]
        public string DocumentNumber { get; set; }

        [Column("type")]
        public int DocumentType { get; set; }

        [Column("sub_type")]
        public int DocumentSubType { get; set; }

        [Column("type_name", TypeName = "varchar(max)")]
        public string DocumentTypeName { get; set; }

        [Column("value_basis")]
        public int DocumentValueBias { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("print_date")]
        public DateTime PrintDate { get; set; }

        [Column("reminder_date")]
        public DateTime ReminderDate { get; set; }

        [Column("print_count")]
        public int PrintCount { get; set; }

        [Column("text_start", TypeName = "varchar(max)")]
        public string TextStart { get; set; }

        [Column("text_start_rtf", TypeName = "varchar(max)")]
        public string TextStartRTF { get; set; }

        [Column("text_head", TypeName = "varchar(max)")]
        public string TextHead { get; set; }

        [Column("text_head_rtf", TypeName = "varchar(max)")]
        public string TextHeadRTF { get; set; }

        [Column("text_paymentterms", TypeName = "varchar(max)")]
        public string TextPaymentterms { get; set; }

        [Column("text_paymentterms_rtf", TypeName = "varchar(max)")]
        public string TextPaymenttermsRTF { get; set; }

        [Column("text_delivery", TypeName = "varchar(max)")]
        public string TextDelivery { get; set; }

        [Column("text_delivery_rtf", TypeName = "varchar(max)")]
        public string TextDeliveryRTF { get; set; }

        [Column("text_end", TypeName = "varchar(max)")]
        public string TextEnd { get; set; }

        [Column("text_end_rtf", TypeName = "varchar(max)")]
        public string TextEndRTF { get; set; }

        [Column("price_sum_net", TypeName = "decimal (38,20)")]
        public decimal NetPriceSum { get; set; }

        [Column("price_gross", TypeName = "decimal (38,20)")]
        public decimal PriceGross { get; set; }

        [Column("is_archive")]
        public bool IsArchived { get; set; }
    }
}

