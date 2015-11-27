namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.ESTPER")]
    public partial class ESTPER
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string COD_EST { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NOMPER { get; set; }
    }
}
