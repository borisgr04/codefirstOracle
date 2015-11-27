namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.AUDITORIA")]
    public partial class AUDITORIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string USUARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MODULO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string OBJETO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string OBS { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FEC_REG { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(16)]
        public string IP { get; set; }
    }
}
