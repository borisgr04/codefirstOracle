namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.INFRACTOR")]
    public partial class INFRACTOR
    {
        public INFRACTOR()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CED_INF { get; set; }

        [Required]
        [StringLength(30)]
        public string APE1_INF { get; set; }

        [Required]
        [StringLength(30)]
        public string APE2_INF { get; set; }

        [Required]
        [StringLength(50)]
        public string NOM_INF { get; set; }

        [StringLength(50)]
        public string EXP_CED_INF { get; set; }

        [StringLength(60)]
        public string DIR_INF { get; set; }

        [StringLength(20)]
        public string TEL_INF { get; set; }

        [StringLength(50)]
        public string COR_INF { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }
    }
}
