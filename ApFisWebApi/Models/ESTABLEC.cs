namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.ESTABLEC")]
    public partial class ESTABLEC
    {
        public ESTABLEC()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
        }

        [Key]
        [StringLength(15)]
        public string NIT_EST { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_EST { get; set; }

        [StringLength(100)]
        public string DIR_EST { get; set; }

        [Required]
        [StringLength(20)]
        public string TEL_EST { get; set; }

        [StringLength(50)]
        public string COR_EST { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }
    }
}
