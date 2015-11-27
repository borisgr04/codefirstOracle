namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.MOVIMIENTOS")]
    public partial class MOVIMIENTOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CODIGO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string TIPO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CANTMOV { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CANTANT { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CANTNEW { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FECHA { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(11)]
        public string USUARIO { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NROACTA { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string COD_BOD { get; set; }

        [StringLength(2)]
        public string EST_MOV { get; set; }

        public long? NROSAL { get; set; }

        public DateTime? FEC_REG { get; set; }

        public virtual BODEGAS BODEGAS { get; set; }

        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
