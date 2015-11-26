namespace CodeFirstOracle.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ApFisConnectionString")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<COUNTRIES> COUNTRIES { get; set; }
        public virtual DbSet<DEPARTMENTS> DEPARTMENTS { get; set; }
        public virtual DbSet<EMPLOYEES> EMPLOYEES { get; set; }
        public virtual DbSet<JOB_HISTORY> JOB_HISTORY { get; set; }
        public virtual DbSet<JOBS> JOBS { get; set; }
        public virtual DbSet<LOCATIONS> LOCATIONS { get; set; }
        public virtual DbSet<REGIONS> REGIONS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COUNTRIES>()
                .Property(e => e.COUNTRY_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRIES>()
                .Property(e => e.COUNTRY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRIES>()
                .Property(e => e.REGION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DEPARTMENTS>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENTS>()
                .HasMany(e => e.EMPLOYEES1)
                .WithOptional(e => e.DEPARTMENTS1)
                .HasForeignKey(e => e.DEPARTMENT_ID);

            modelBuilder.Entity<EMPLOYEES>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEES>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEES>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEES>()
                .Property(e => e.PHONE_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEES>()
                .Property(e => e.JOB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEES>()
                .Property(e => e.SALARY)
                .HasPrecision(8, 2);

            modelBuilder.Entity<EMPLOYEES>()
                .Property(e => e.COMMISSION_PCT)
                .HasPrecision(2, 2);

            modelBuilder.Entity<EMPLOYEES>()
                .HasMany(e => e.DEPARTMENTS)
                .WithOptional(e => e.EMPLOYEES)
                .HasForeignKey(e => e.MANAGER_ID);

            modelBuilder.Entity<EMPLOYEES>()
                .HasMany(e => e.EMPLOYEES1)
                .WithOptional(e => e.EMPLOYEES2)
                .HasForeignKey(e => e.MANAGER_ID);

            modelBuilder.Entity<EMPLOYEES>()
                .HasMany(e => e.JOB_HISTORY)
                .WithRequired(e => e.EMPLOYEES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB_HISTORY>()
                .Property(e => e.JOB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBS>()
                .Property(e => e.JOB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBS>()
                .Property(e => e.JOB_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBS>()
                .HasMany(e => e.EMPLOYEES)
                .WithRequired(e => e.JOBS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOBS>()
                .HasMany(e => e.JOB_HISTORY)
                .WithRequired(e => e.JOBS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOCATIONS>()
                .Property(e => e.STREET_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATIONS>()
                .Property(e => e.POSTAL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATIONS>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATIONS>()
                .Property(e => e.STATE_PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATIONS>()
                .Property(e => e.COUNTRY_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REGIONS>()
                .Property(e => e.REGION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REGIONS>()
                .Property(e => e.REGION_NAME)
                .IsUnicode(false);
        }
    }
}
