namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.PRODUCTOS")]
    public partial class PRODUCTOS
    {
        public PRODUCTOS()
        {
            PRODACTAS = new HashSet<PRODACTAS>();
            PRODBOD = new HashSet<PRODBOD>();
            MOVIMIENTOS = new HashSet<MOVIMIENTOS>();
            PRODACTAS_ANU = new HashSet<PRODACTAS_ANU>();
            SALIDAS = new HashSet<SALIDAS>();
        }

        [Key]
        [StringLength(10)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPCION { get; set; }

        public long? CANTIDAD { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_SCAT { get; set; }

        [Required]
        [StringLength(5)]
        public string CAP_PROD { get; set; }

        [Required]
        [StringLength(1)]
        public string TIP_FAB { get; set; }

        [StringLength(10)]
        public string CODIGO_ANT { get; set; }

        public decimal? VALOR { get; set; }

        public decimal? VAL_ILEGAL { get; set; }

        [StringLength(20)]
        public string GRADOA { get; set; }

        public virtual CAP_PROD CAP_PROD1 { get; set; }

        public virtual ICollection<PRODACTAS> PRODACTAS { get; set; }

        public virtual ICollection<PRODBOD> PRODBOD { get; set; }

        public virtual ICollection<MOVIMIENTOS> MOVIMIENTOS { get; set; }

        public virtual SCAT_PROD SCAT_PROD { get; set; }

        public virtual ICollection<PRODACTAS_ANU> PRODACTAS_ANU { get; set; }

        public virtual ICollection<SALIDAS> SALIDAS { get; set; }
    }
}
