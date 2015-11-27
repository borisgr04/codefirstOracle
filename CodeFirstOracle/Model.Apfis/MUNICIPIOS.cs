namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.MUNICIPIOS")]
    public partial class MUNICIPIOS
    {
        public MUNICIPIOS()
        {
            ACTAS = new HashSet<ACTAS>();
            ACTAS_ANU = new HashSet<ACTAS_ANU>();
        }

        [Key]
        [StringLength(5)]
        public string COD_MUN { get; set; }

        [Required]
        [StringLength(50)]
        public string NOM_MUN { get; set; }

        public virtual ICollection<ACTAS> ACTAS { get; set; }

        public virtual ICollection<ACTAS_ANU> ACTAS_ANU { get; set; }
    }
}
