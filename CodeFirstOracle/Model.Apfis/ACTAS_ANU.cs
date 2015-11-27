namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.ACTAS_ANU")]
    public partial class ACTAS_ANU
    {
        public ACTAS_ANU()
        {
            PRODACTAS_ANU = new HashSet<PRODACTAS_ANU>();
        }

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

        [Required]
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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NRO_ANU { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }

        public virtual INFRACTOR INFRACTOR { get; set; }

        public virtual ESTABLEC ESTABLEC { get; set; }

        public virtual BODEGAS BODEGAS { get; set; }

        public virtual MUNICIPIOS MUNICIPIOS { get; set; }

        public virtual CGOPERATIVO CGOPERATIVO { get; set; }

        public virtual RAUTORIDAD RAUTORIDAD { get; set; }

        public virtual RBODEGA RBODEGA { get; set; }

        public virtual ICollection<PRODACTAS_ANU> PRODACTAS_ANU { get; set; }
    }
}
