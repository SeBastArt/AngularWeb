using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("document_position")]
    public class DocumentPosition : BaseEntity
    {
        [Column("id")]
        public long DocumentPositionId { get; set; }

        [Column("position_number")]
        public int PositionNumber { get; set; }

        [Column("position_number_text", TypeName = "varchar(max)")]
        public string PositionNumberText { get; set; }

        [Column("position_type")]
        public int PositionType { get; set; }

        [Column("article_name", TypeName = "varchar(max)")]
        public string ArticleName { get; set; }

        [Column("article_name_extern", TypeName = "varchar(max)")]
        public string ArticleNameExtern { get; set; }

        [Column("quantitiy", TypeName = "decimal (38,20)")]
        public decimal Quantity { get; set; }

        [Column("scale_unit_qty")]
        public int ScaleUnitQty { get; set; }

        [Column("scale_unit_type")]
        public int ScaleUnitType { get; set; }

        [Column("scale_unit", TypeName = "varchar(max)")]
        public string ScaleUnit { get; set; }

        [Column("delivered_quantity", TypeName = "decimal (38,20)")]
        public decimal DeliveryQty { get; set; }

        [Column("is_partial_delivery")]
        public bool IsPartialDelivered { get; set; }

        [Column("price_base", TypeName = "decimal (38,20)")]
        public decimal PriceBase { get; set; }

        [Column("price_per_unit", TypeName = "decimal (38,20)")]
        public decimal PricePerUnit { get; set; }

        [Column("price_total", TypeName = "decimal (38,20)")]
        public decimal PriceTotal { get; set; }

        [Column("sales_tax_percent", TypeName = "decimal (38,20)")]
        public decimal SalesTaxPercent { get; set; }

        public long ParentId { get; set; }

        [Column("fk_parent")]
        public virtual DocumentPosition Parent { get; set; }

        public long DocumentId { get; set; }

        [Column("fk_document")]
        public Document Document { get; set; }
    }
}
