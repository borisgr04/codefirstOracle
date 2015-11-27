namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.ESTACTAS")]
    public partial class ESTACTAS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NROACTA { get; set; }

        public DateTime FECHA { get; set; }

        [Required]
        [StringLength(250)]
        public string OBS_EST { get; set; }

        [Required]
        [StringLength(11)]
        public string USUARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ESTANT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ESTADO { get; set; }

        public DateTime FEC_REG { get; set; }

        [StringLength(250)]
        public string FMTO_EST { get; set; }

        public virtual ACTAS ACTAS { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
