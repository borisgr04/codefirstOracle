namespace CodeFirstOracle.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.EMPLOYEES")]
    public partial class EMPLOYEES
    {
        public EMPLOYEES()
        {
            DEPARTMENTS = new HashSet<DEPARTMENTS>();
            EMPLOYEES1 = new HashSet<EMPLOYEES>();
            JOB_HISTORY = new HashSet<JOB_HISTORY>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMPLOYEE_ID { get; set; }

        [StringLength(20)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string PHONE_NUMBER { get; set; }

        public DateTime HIRE_DATE { get; set; }

        [Required]
        [StringLength(10)]
        public string JOB_ID { get; set; }

        public decimal? SALARY { get; set; }

        public decimal? COMMISSION_PCT { get; set; }

        public int? MANAGER_ID { get; set; }

        public short? DEPARTMENT_ID { get; set; }

        public virtual ICollection<DEPARTMENTS> DEPARTMENTS { get; set; }

        public virtual DEPARTMENTS DEPARTMENTS1 { get; set; }

        public virtual JOBS JOBS { get; set; }

        public virtual ICollection<EMPLOYEES> EMPLOYEES1 { get; set; }

        public virtual EMPLOYEES EMPLOYEES2 { get; set; }

        public virtual ICollection<JOB_HISTORY> JOB_HISTORY { get; set; }
    }
}
