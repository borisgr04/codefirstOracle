namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.PERFILES")]
    public partial class PERFILES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string NOMPER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CODPER { get; set; }

        [Required]
        [StringLength(50)]
        public string TITOPC { get; set; }

        public byte NIVOPC { get; set; }

        public short TIPOPC { get; set; }

        [Required]
        [StringLength(50)]
        public string EJEOPC { get; set; }

        [Required]
        [StringLength(50)]
        public string DESOPC { get; set; }
    }
}
