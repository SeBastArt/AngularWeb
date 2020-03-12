using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    [Table("article_article")]
    public class Article : BaseEntity
    {
        [Column("id")]
        public long ArticleId { get; set; }

        [Column("name")]
        public virtual string Name { get; set; }

        [Column("material_type")]
        public virtual int MaterialType { get; set; }

        [Column("is_archived")]
        public virtual bool IsArchived { get; set; }

        [Column("is_discontinued")]
        public virtual bool IsDiscontinued { get; set; }

        [Column("is_batch")]
        public virtual bool IsBatch { get; set; }

        [Column("is_multistock")]
        public virtual bool IsMultistock { get; set; }

        [Column("is_provision_enabled")]
        public virtual bool IsProvisionEnabled { get; set; }

        [Column("is_discount_enabled")]
        public virtual bool IsDiscountEnabled { get; set; }

        [Column("is_disposition")]
        public virtual bool IsDisposition { get; set; }

        [Column("is_casting")]
        public virtual bool IsCasting { get; set; }

        [Column("scale_unit_qty")]
        public virtual int ScaleUnitQty { get; set; }

        [Column("scale_unit_type")]
        public virtual int ScaleUnitType { get; set; }

        [Column("unit_stock")]
        public virtual int UnitStock { get; set; }

        [Column("unit_stock_in")]
        public virtual int UnitStockIn { get; set; }

        [Column("unit_stock_out")]
        public virtual int UnitStockOut { get; set; }

        [Column("dim_area")]
        public virtual int DimArea { get; set; }

        [Column("dim_length")]
        public virtual int DimLength { get; set; }

        [Column("dim_2")]
        public virtual int Dim2 { get; set; }

        [Column("dim_3")]
        public virtual int Dim3 { get; set; }

        [Column("dim_4")]
        public virtual int Dim4 { get; set; }

        [Column("specific_weight", TypeName = "decimal (38,20)")]
        public virtual decimal SpecificWeight { get; set; }

        [Column("item_number")]
        public virtual string ItemNumber { get; set; }

        [Column("drawing_number")]
        public virtual string DrawingNumber { get; set; }

        [Column("din_norm1")]
        public virtual string DinNorm1 { get; set; }

        [Column("din_norm2")]
        public virtual string DinNorm2 { get; set; }

        [Column("fk_picture_1")]
        public long Picture1Id { get; set; }

        public virtual FAGBinary Picture1 { get; set; }

        [Column("fk_picture_2")]
        public long Picture2Id { get; set; }

        public virtual FAGBinary Picture2 { get; set; }

        [Column("fk_group")]
        public long ArticleGroupId { get; set; }

        public virtual ArticleGroup ArticleGroup { get; set; }

        [Column("fk_type")]
        public long ArticleTypeId { get; set; }

        public virtual ArticleType ArticleType { get; set; }

        //[Column("fk_text")]
        //public long ArticleTextId { get; set; }

        //public ArticleText ArticleText { get; set; }

        public IEnumerable<ArticlePlace> ArticlePlaces { get; set; } = new List<ArticlePlace>();

        public IEnumerable<ArticlePriceListIn> ArticlePriceListIns { get; set; } = new List<ArticlePriceListIn>();
        public IEnumerable<ArticlePriceListOut> ArticlePriceListInOuts { get; set; } = new List<ArticlePriceListOut>();
    }
}
