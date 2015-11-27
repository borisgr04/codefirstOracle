namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.SALIDAS")]
    public partial class SALIDAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NRO_SAL { get; set; }

        public DateTime FEC_SAL { get; set; }

        public long NROACTA { get; set; }

        [Required]
        [StringLength(2)]
        public string ESTACTA { get; set; }

        [Required]
        [StringLength(6)]
        public string TIP_SAL { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_PROD { get; set; }

        public long CAN_ANT { get; set; }

        public long CAN_SAL { get; set; }

        [StringLength(300)]
        public string OBS_SAL { get; set; }

        [Required]
        [StringLength(8)]
        public string USUARIO { get; set; }

        public DateTime FEC_REG { get; set; }

        [Required]
        [StringLength(40)]
        public string AUT_POR { get; set; }

        [Required]
        [StringLength(50)]
        public string ANEXO { get; set; }

        [StringLength(2)]
        public string EST_SAL { get; set; }

        public virtual ACTAS ACTAS { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
