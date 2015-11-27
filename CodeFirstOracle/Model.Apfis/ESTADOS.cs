namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.ESTADOS")]
    public partial class ESTADOS
    {
        public ESTADOS()
        {
            FMTOEST = new HashSet<FMTOEST>();
            ESTADOS1 = new HashSet<ESTADOS>();
            ESTADOS2 = new HashSet<ESTADOS>();
        }

        [Key]
        [StringLength(2)]
        public string COD_EST { get; set; }

        [Required]
        [StringLength(255)]
        public string DES_EST { get; set; }

        public bool INICIO { get; set; }

        public bool FIN { get; set; }

        public virtual ICollection<FMTOEST> FMTOEST { get; set; }

        public virtual ICollection<ESTADOS> ESTADOS1 { get; set; }

        public virtual ICollection<ESTADOS> ESTADOS2 { get; set; }
    }
}
