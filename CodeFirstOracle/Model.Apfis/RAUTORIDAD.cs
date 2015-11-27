namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.RAUTORIDAD")]
    public partial class RAUTORIDAD
    {
        public RAUTORIDAD()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CED_AUT { get; set; }

        [Required]
        [StringLength(30)]
        public string APE1_AUT { get; set; }

        [Required]
        [StringLength(30)]
        public string APE2_AUT { get; set; }

        [Required]
        [StringLength(20)]
        public string NOM_AUT { get; set; }

        [Required]
        [StringLength(20)]
        public string EXP_CED_AUT { get; set; }

        [Required]
        [StringLength(30)]
        public string DIR_AUT { get; set; }

        [Required]
        [StringLength(20)]
        public string TEL_AUT { get; set; }

        [Required]
        [StringLength(50)]
        public string COR_AUT { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }
    }
}
