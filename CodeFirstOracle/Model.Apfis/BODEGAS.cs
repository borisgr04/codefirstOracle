namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.BODEGAS")]
    public partial class BODEGAS
    {
        public BODEGAS()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
            MOVIMIENTOS = new HashSet<MOVIMIENTOS>();
            PRODBOD = new HashSet<PRODBOD>();
        }

        [Key]
        [StringLength(10)]
        public string COD_BOD { get; set; }

        [Required]
        [StringLength(30)]
        public string NOM_BOD { get; set; }

        [Required]
        [StringLength(2)]
        public string EST_BOD { get; set; }

        [Required]
        [StringLength(40)]
        public string DIR_BOD { get; set; }

        [StringLength(20)]
        public string TEL_BOD { get; set; }

        [StringLength(50)]
        public string EMA_BOD { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_MUN { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }

        public virtual ICollection<MOVIMIENTOS> MOVIMIENTOS { get; set; }

        public virtual ICollection<PRODBOD> PRODBOD { get; set; }
    }
}
