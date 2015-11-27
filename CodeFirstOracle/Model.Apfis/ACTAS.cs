namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.ACTAS")]
    public partial class ACTAS
    {
        public ACTAS()
        {
            ACTASANEXO = new HashSet<ACTASANEXO>();
            ESTACTAS = new HashSet<ESTACTAS>();
            PRODACTAS = new HashSet<PRODACTAS>();
            SALIDAS = new HashSet<SALIDAS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NROACTA { get; set; }

        public DateTime FECHAINI { get; set; }

        public DateTime FECHAFIN { get; set; }

        public decimal? FACTURA { get; set; }

        [Required]
        [StringLength(20)]
        public string OTRODOC { get; set; }

        public long CED_INF { get; set; }

        public long TOTALUNID { get; set; }

        [StringLength(256)]
        public string EXPLICACION { get; set; }

        public long? REL_FACTCOM { get; set; }

        public long? REL_MANCARGA { get; set; }

        [StringLength(20)]
        public string REL_OTROS { get; set; }

        public long? REL_FACTCOM_FOLIO { get; set; }

        public long? REL_MANCARGA_FOLIO { get; set; }

        public long? REL_OTROS_FOLIO { get; set; }

        public long IDE_COOR { get; set; }

        public long IDE_AUTORIDAD { get; set; }

        public long IDE_BODEGA { get; set; }

        [Required]
        [StringLength(2)]
        public string ESTADO { get; set; }

        [Required]
        [StringLength(11)]
        public string FIRMA { get; set; }

        [Required]
        [StringLength(8)]
        public string USUARIO { get; set; }

        public DateTime FEC_REG { get; set; }

        [Required]
        [StringLength(2)]
        public string FCOOR { get; set; }

        [Required]
        [StringLength(2)]
        public string FAUT { get; set; }

        [Required]
        [StringLength(2)]
        public string FINF { get; set; }

        [Required]
        [StringLength(2)]
        public string FBOD { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_BOD { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_MUN { get; set; }

        [Required]
        [StringLength(15)]
        public string NIT_EST { get; set; }

        [StringLength(20)]
        public string TIPOAPRE { get; set; }

        [StringLength(40)]
        public string CAUSALES { get; set; }

        [StringLength(30)]
        public string APREPOR { get; set; }

        public DateTime? FECPOL { get; set; }

        [StringLength(15)]
        public string CATPROD { get; set; }

        [StringLength(10)]
        public string TIP_RES { get; set; }

        [StringLength(4000)]
        public string PRU_CON { get; set; }

        [StringLength(30)]
        public string NRO_NOT { get; set; }

        [StringLength(60)]
        public string EMP_NOT { get; set; }

        public DateTime? FEC_NOT { get; set; }

        [StringLength(4000)]
        public string ARG_CON { get; set; }

        [StringLength(30)]
        public string NRO_NOTD { get; set; }

        [StringLength(60)]
        public string EMP_NOTD { get; set; }

        public DateTime? FEC_NOTD { get; set; }

        public DateTime? FEC_VEND { get; set; }

        [StringLength(20)]
        public string TIP_NOT { get; set; }

        [StringLength(20)]
        public string TIP_NOTR { get; set; }

        public DateTime? FEC_NOTP_RR { get; set; }

        [StringLength(2000)]
        public string SEDEMOSTRO { get; set; }

        public int? TIEMCIERRE { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }

        public virtual INFRACTOR INFRACTOR { get; set; }

        public virtual BODEGAS BODEGAS { get; set; }

        public virtual MUNICIPIOS MUNICIPIOS { get; set; }

        public virtual CGOPERATIVO CGOPERATIVO { get; set; }

        public virtual RAUTORIDAD RAUTORIDAD { get; set; }

        public virtual RBODEGA RBODEGA { get; set; }

        public virtual ESTABLEC ESTABLEC { get; set; }

        public virtual ICollection<ACTASANEXO> ACTASANEXO { get; set; }

        public virtual ICollection<ESTACTAS> ESTACTAS { get; set; }

        public virtual ICollection<PRODACTAS> PRODACTAS { get; set; }

        public virtual ICollection<SALIDAS> SALIDAS { get; set; }
    }
}
