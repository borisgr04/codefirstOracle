namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApFisContext : DbContext
    {
        public ApFisContext()
            : base("name=ApFisContext")
        {
        }

        public virtual DbSet<ACTAS> ACTAS { get; set; }
        public virtual DbSet<ACTAS_ANU> ACTAS_ANU { get; set; }
        public virtual DbSet<ACTASANEXO> ACTASANEXO { get; set; }
        public virtual DbSet<BODEGAS> BODEGAS { get; set; }
        public virtual DbSet<CAP_PROD> CAP_PROD { get; set; }
        public virtual DbSet<CAT_PROD> CAT_PROD { get; set; }
        public virtual DbSet<CAUSALES> CAUSALES { get; set; }
        public virtual DbSet<CGOPERATIVO> CGOPERATIVO { get; set; }
        public virtual DbSet<ESTABLEC> ESTABLEC { get; set; }
        public virtual DbSet<ESTACTAS> ESTACTAS { get; set; }
        public virtual DbSet<ESTADOS> ESTADOS { get; set; }
        public virtual DbSet<ESTPER> ESTPER { get; set; }
        public virtual DbSet<FMTOEST> FMTOEST { get; set; }
        public virtual DbSet<INFRACTOR> INFRACTOR { get; set; }
        public virtual DbSet<MUNICIPIOS> MUNICIPIOS { get; set; }
        public virtual DbSet<PAGAUT> PAGAUT { get; set; }
        public virtual DbSet<PERFILES> PERFILES { get; set; }
        public virtual DbSet<PRODACTAS> PRODACTAS { get; set; }
        public virtual DbSet<PRODBOD> PRODBOD { get; set; }
        public virtual DbSet<PRODUCTOS> PRODUCTOS { get; set; }
        public virtual DbSet<RAUTORIDAD> RAUTORIDAD { get; set; }
        public virtual DbSet<RBODEGA> RBODEGA { get; set; }
        public virtual DbSet<SALIDAS> SALIDAS { get; set; }
        public virtual DbSet<SCAT_PROD> SCAT_PROD { get; set; }
        public virtual DbSet<TIPO_FND> TIPO_FND { get; set; }
        public virtual DbSet<TIPSAL> TIPSAL { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<AUDITORIA> AUDITORIA { get; set; }
        public virtual DbSet<MOVIMIENTOS> MOVIMIENTOS { get; set; }
        public virtual DbSet<PRODACTAS_ANU> PRODACTAS_ANU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACTAS>()
                .Property(e => e.FACTURA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.OTRODOC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.EXPLICACION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.REL_OTROS)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.ESTADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.FIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.FCOOR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.FAUT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.FINF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.FBOD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.COD_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.NIT_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.TIPOAPRE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.CAUSALES)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.APREPOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.CATPROD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.TIP_RES)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.PRU_CON)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.NRO_NOT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.EMP_NOT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.ARG_CON)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.NRO_NOTD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.EMP_NOTD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.TIP_NOT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.TIP_NOTR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .Property(e => e.SEDEMOSTRO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS>()
                .HasMany(e => e.ACTASANEXO)
                .WithRequired(e => e.ACTAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACTAS>()
                .HasMany(e => e.ESTACTAS)
                .WithRequired(e => e.ACTAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACTAS>()
                .HasMany(e => e.PRODACTAS)
                .WithRequired(e => e.ACTAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACTAS>()
                .HasMany(e => e.SALIDAS)
                .WithRequired(e => e.ACTAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.FACTURA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.OTRODOC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.EXPLICACION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.REL_OTROS)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.ESTADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.FIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.FCOOR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.FAUT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.FINF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.FBOD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.COD_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAS_ANU>()
                .Property(e => e.NIT_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ACTASANEXO>()
                .Property(e => e.RUT_ANE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTASANEXO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTASANEXO>()
                .Property(e => e.DES_ANE)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .Property(e => e.COD_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .Property(e => e.NOM_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .Property(e => e.EST_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .Property(e => e.DIR_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .Property(e => e.TEL_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .Property(e => e.EMA_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<BODEGAS>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.BODEGAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODEGAS>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.BODEGAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODEGAS>()
                .HasMany(e => e.MOVIMIENTOS)
                .WithRequired(e => e.BODEGAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODEGAS>()
                .HasMany(e => e.PRODBOD)
                .WithRequired(e => e.BODEGAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAP_PROD>()
                .Property(e => e.COD_CAP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAP_PROD>()
                .Property(e => e.DES_CAP)
                .IsUnicode(false);

            modelBuilder.Entity<CAP_PROD>()
                .Property(e => e.COD_CAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAP_PROD>()
                .Property(e => e.PRE_FND)
                .IsUnicode(false);

            modelBuilder.Entity<CAP_PROD>()
                .HasMany(e => e.PRODUCTOS)
                .WithRequired(e => e.CAP_PROD1)
                .HasForeignKey(e => e.CAP_PROD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_PROD>()
                .Property(e => e.COD_CAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAT_PROD>()
                .Property(e => e.DES_CAT)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_PROD>()
                .HasMany(e => e.CAP_PROD)
                .WithRequired(e => e.CAT_PROD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_PROD>()
                .HasMany(e => e.SCAT_PROD)
                .WithRequired(e => e.CAT_PROD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAUSALES>()
                .Property(e => e.COD_CAUSAL)
                .IsUnicode(false);

            modelBuilder.Entity<CAUSALES>()
                .Property(e => e.DES_CAUSAL)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .Property(e => e.APE1_CGO)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .Property(e => e.APE2_CGO)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .Property(e => e.NOM_CGO)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .Property(e => e.EXP_CED_CGO)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .Property(e => e.DIR_CGO)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .Property(e => e.TEL_CGO)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .Property(e => e.COR_CGO)
                .IsUnicode(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.CGOPERATIVO)
                .HasForeignKey(e => e.IDE_COOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGOPERATIVO>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.CGOPERATIVO)
                .HasForeignKey(e => e.IDE_COOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTABLEC>()
                .Property(e => e.NIT_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABLEC>()
                .Property(e => e.NOM_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABLEC>()
                .Property(e => e.DIR_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABLEC>()
                .Property(e => e.TEL_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABLEC>()
                .Property(e => e.COR_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTABLEC>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.ESTABLEC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTABLEC>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.ESTABLEC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTACTAS>()
                .Property(e => e.OBS_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTACTAS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTACTAS>()
                .Property(e => e.ESTANT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTACTAS>()
                .Property(e => e.ESTADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTACTAS>()
                .Property(e => e.FMTO_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.COD_EST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.DES_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.FMTOEST)
                .WithRequired(e => e.ESTADOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.ESTADOS1)
                .WithMany(e => e.ESTADOS2)
                .Map(m => m.ToTable("ESTREL", "APFIS").MapLeftKey("PARA").MapRightKey("DE"));

            modelBuilder.Entity<ESTPER>()
                .Property(e => e.COD_EST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTPER>()
                .Property(e => e.NOMPER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FMTOEST>()
                .Property(e => e.COD_EST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FMTOEST>()
                .Property(e => e.RUT_FMT)
                .IsUnicode(false);

            modelBuilder.Entity<FMTOEST>()
                .Property(e => e.DES_FMT)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .Property(e => e.APE1_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .Property(e => e.APE2_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .Property(e => e.NOM_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .Property(e => e.EXP_CED_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .Property(e => e.DIR_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .Property(e => e.TEL_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .Property(e => e.COR_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INFRACTOR>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.INFRACTOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INFRACTOR>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.INFRACTOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUNICIPIOS>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIOS>()
                .Property(e => e.NOM_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIOS>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.MUNICIPIOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUNICIPIOS>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.MUNICIPIOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAGAUT>()
                .Property(e => e.COD_PER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAGAUT>()
                .Property(e => e.NOM_PAG)
                .IsUnicode(false);

            modelBuilder.Entity<PERFILES>()
                .Property(e => e.NOMPER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERFILES>()
                .Property(e => e.CODPER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERFILES>()
                .Property(e => e.TITOPC)
                .IsUnicode(false);

            modelBuilder.Entity<PERFILES>()
                .Property(e => e.EJEOPC)
                .IsUnicode(false);

            modelBuilder.Entity<PERFILES>()
                .Property(e => e.DESOPC)
                .IsUnicode(false);

            modelBuilder.Entity<PRODACTAS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODACTAS>()
                .Property(e => e.ESTADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODBOD>()
                .Property(e => e.COD_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<PRODBOD>()
                .Property(e => e.COD_PROD)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.COD_SCAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.CAP_PROD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.TIP_FAB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.CODIGO_ANT)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.VALOR)
                .HasPrecision(17, 4);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.VAL_ILEGAL)
                .HasPrecision(17, 4);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.GRADOA)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.PRODACTAS)
                .WithRequired(e => e.PRODUCTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.PRODBOD)
                .WithRequired(e => e.PRODUCTOS)
                .HasForeignKey(e => e.COD_PROD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.MOVIMIENTOS)
                .WithRequired(e => e.PRODUCTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.PRODACTAS_ANU)
                .WithRequired(e => e.PRODUCTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.SALIDAS)
                .WithRequired(e => e.PRODUCTOS)
                .HasForeignKey(e => e.COD_PROD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .Property(e => e.APE1_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .Property(e => e.APE2_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .Property(e => e.NOM_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .Property(e => e.EXP_CED_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .Property(e => e.DIR_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .Property(e => e.TEL_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .Property(e => e.COR_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.RAUTORIDAD)
                .HasForeignKey(e => e.IDE_AUTORIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RAUTORIDAD>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.RAUTORIDAD)
                .HasForeignKey(e => e.IDE_AUTORIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RBODEGA>()
                .Property(e => e.APE1_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<RBODEGA>()
                .Property(e => e.APE2_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<RBODEGA>()
                .Property(e => e.NOM_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<RBODEGA>()
                .Property(e => e.EXP_CED_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<RBODEGA>()
                .Property(e => e.DIR_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<RBODEGA>()
                .Property(e => e.TEL_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<RBODEGA>()
                .Property(e => e.COR_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<RBODEGA>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.RBODEGA)
                .HasForeignKey(e => e.IDE_BODEGA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RBODEGA>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.RBODEGA)
                .HasForeignKey(e => e.IDE_BODEGA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.ESTACTA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.TIP_SAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.COD_PROD)
                .IsUnicode(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.OBS_SAL)
                .IsUnicode(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.AUT_POR)
                .IsUnicode(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.ANEXO)
                .IsUnicode(false);

            modelBuilder.Entity<SALIDAS>()
                .Property(e => e.EST_SAL)
                .IsUnicode(false);

            modelBuilder.Entity<SCAT_PROD>()
                .Property(e => e.COD_SCAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SCAT_PROD>()
                .Property(e => e.DES_SCAT)
                .IsUnicode(false);

            modelBuilder.Entity<SCAT_PROD>()
                .Property(e => e.COD_CAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SCAT_PROD>()
                .Property(e => e.COD_FND)
                .IsUnicode(false);

            modelBuilder.Entity<SCAT_PROD>()
                .Property(e => e.COD_SCAT_ANT)
                .IsUnicode(false);

            modelBuilder.Entity<SCAT_PROD>()
                .HasMany(e => e.PRODUCTOS)
                .WithRequired(e => e.SCAT_PROD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_FND>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_FND>()
                .Property(e => e.NOM_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPSAL>()
                .Property(e => e.COD_SAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPSAL>()
                .Property(e => e.DES_SAL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.NOM_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.APE_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.SEX_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.DIR_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.TEL_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.CEL_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.EMA_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.OCU_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.LUG_NAC)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.TEMA)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.EST_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.ACTAS)
                .WithRequired(e => e.USUARIOS)
                .HasForeignKey(e => e.USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.ACTAS_ANU)
                .WithRequired(e => e.USUARIOS)
                .HasForeignKey(e => e.USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.ESTACTAS)
                .WithRequired(e => e.USUARIOS)
                .HasForeignKey(e => e.USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.SALIDAS)
                .WithRequired(e => e.USUARIOS)
                .HasForeignKey(e => e.USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.OBJETO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.OBS)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMIENTOS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMIENTOS>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMIENTOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMIENTOS>()
                .Property(e => e.COD_BOD)
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMIENTOS>()
                .Property(e => e.EST_MOV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODACTAS_ANU>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODACTAS_ANU>()
                .Property(e => e.ESTADO)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
