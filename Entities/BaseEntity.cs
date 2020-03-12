using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Entities
{
    public class BaseEntity
    {
        [Column("created")]
        public virtual DateTime Created { get; set; }
       
        [Column("modified")]
        public virtual DateTime Modified { get; set; }
        
        [Column("created_by")]
        public virtual long CreatedBy { get; set; }
        
        [Column("modified_by")]
        public virtual long ModifiedBy { get; set; }

        [Column("info", TypeName = "varchar(max)")]
        public virtual string Info { get; set; }

        [Column("info_rtf", TypeName = "varchar(max)")]
        public virtual string InfoRtf { get; set; }
    }
}
