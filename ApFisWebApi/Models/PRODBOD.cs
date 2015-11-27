namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.PRODBOD")]
    public partial class PRODBOD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string COD_BOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string COD_PROD { get; set; }

        public long CAN_PROD { get; set; }

        public virtual BODEGAS BODEGAS { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
