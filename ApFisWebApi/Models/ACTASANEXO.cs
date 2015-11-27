namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.ACTASANEXO")]
    public partial class ACTASANEXO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NROACTA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RUT_ANE { get; set; }

        public long? IDE_ANEX_ACT { get; set; }

        [Required]
        [StringLength(8)]
        public string USUARIO { get; set; }

        public DateTime FECHA { get; set; }

        [Required]
        [StringLength(100)]
        public string DES_ANE { get; set; }

        public virtual ACTAS ACTAS { get; set; }
    }
}
