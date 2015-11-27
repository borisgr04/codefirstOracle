namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.USUARIOS")]
    public partial class USUARIOS
    {
        public USUARIOS()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
            ESTACTAS = new HashSet<ESTACTAS>();
            SALIDAS = new HashSet<SALIDAS>();
        }

        [Key]
        [StringLength(8)]
        public string USERNAME { get; set; }

        [StringLength(41)]
        public string PASSWORD { get; set; }

        public int? CED_USU { get; set; }

        [StringLength(25)]
        public string NOM_USU { get; set; }

        [StringLength(25)]
        public string APE_USU { get; set; }

        [StringLength(9)]
        public string SEX_USU { get; set; }

        public DateTime? FEC_USU { get; set; }

        [StringLength(40)]
        public string DIR_USU { get; set; }

        [StringLength(20)]
        public string TEL_USU { get; set; }

        [StringLength(20)]
        public string CEL_USU { get; set; }

        [StringLength(30)]
        public string EMA_USU { get; set; }

        [StringLength(100)]
        public string OCU_USU { get; set; }

        [StringLength(25)]
        public string LUG_NAC { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(10)]
        public string PERFIL { get; set; }

        [StringLength(10)]
        public string TEMA { get; set; }

        [StringLength(2)]
        public string EST_USU { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }

        public virtual ICollection<ESTACTAS> ESTACTAS { get; set; }

        public virtual ICollection<SALIDAS> SALIDAS { get; set; }
    }
}
