namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.FMTOEST")]
    public partial class FMTOEST
    {
        [Required]
        [StringLength(2)]
        public string COD_EST { get; set; }

        [Required]
        [StringLength(255)]
        public string RUT_FMT { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IDE_FMT { get; set; }

        [StringLength(50)]
        public string DES_FMT { get; set; }

        public virtual ESTADOS ESTADOS { get; set; }
    }
}
