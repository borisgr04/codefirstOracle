namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.PRODACTAS_ANU")]
    public partial class PRODACTAS_ANU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NROACTA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CODIGO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UNIDADES { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PRECIOUNIT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string ESTADO { get; set; }

        public long? NRO_ANU { get; set; }

        public long? PRODSAL { get; set; }

        public virtual ACTAS_ANU ACTAS_ANU { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
