namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.CAUSALES")]
    public partial class CAUSALES
    {
        [Key]
        [StringLength(5)]
        public string COD_CAUSAL { get; set; }

        [Required]
        [StringLength(400)]
        public string DES_CAUSAL { get; set; }
    }
}
