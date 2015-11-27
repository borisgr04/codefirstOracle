namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.CGOPERATIVO")]
    public partial class CGOPERATIVO
    {
        public CGOPERATIVO()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CED_CGO { get; set; }

        [Required]
        [StringLength(30)]
        public string APE1_CGO { get; set; }

        [Required]
        [StringLength(30)]
        public string APE2_CGO { get; set; }

        [Required]
        [StringLength(20)]
        public string NOM_CGO { get; set; }

        [Required]
        [StringLength(20)]
        public string EXP_CED_CGO { get; set; }

        [Required]
        [StringLength(30)]
        public string DIR_CGO { get; set; }

        [Required]
        [StringLength(20)]
        public string TEL_CGO { get; set; }

        [Required]
        [StringLength(30)]
        public string COR_CGO { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }
    }
}
