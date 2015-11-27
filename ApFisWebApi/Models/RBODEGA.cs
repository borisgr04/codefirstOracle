namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.RBODEGA")]
    public partial class RBODEGA
    {
        public RBODEGA()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CED_BOD { get; set; }

        [Required]
        [StringLength(30)]
        public string APE1_BOD { get; set; }

        [Required]
        [StringLength(30)]
        public string APE2_BOD { get; set; }

        [Required]
        [StringLength(20)]
        public string NOM_BOD { get; set; }

        [Required]
        [StringLength(20)]
        public string EXP_CED_BOD { get; set; }

        [Required]
        [StringLength(30)]
        public string DIR_BOD { get; set; }

        [Required]
        [StringLength(20)]
        public string TEL_BOD { get; set; }

        [Required]
        [StringLength(50)]
        public string COR_BOD { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }
    }
}
