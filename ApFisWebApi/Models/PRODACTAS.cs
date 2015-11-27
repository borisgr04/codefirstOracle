namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.PRODACTAS")]
    public partial class PRODACTAS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NROACTA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CODIGO { get; set; }

        public long UNIDADES { get; set; }

        public long PRECIOUNIT { get; set; }

        [Required]
        [StringLength(2)]
        public string ESTADO { get; set; }

        public long PRODSAL { get; set; }

        public virtual ACTAS ACTAS { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
