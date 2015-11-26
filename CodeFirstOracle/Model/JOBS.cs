namespace CodeFirstOracle.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.JOBS")]
    public partial class JOBS
    {
        public JOBS()
        {
            EMPLOYEES = new HashSet<EMPLOYEES>();
            JOB_HISTORY = new HashSet<JOB_HISTORY>();
        }

        [Key]
        [StringLength(10)]
        public string JOB_ID { get; set; }

        [Required]
        [StringLength(35)]
        public string JOB_TITLE { get; set; }

        public int? MIN_SALARY { get; set; }

        public int? MAX_SALARY { get; set; }

        public virtual ICollection<EMPLOYEES> EMPLOYEES { get; set; }

        public virtual ICollection<JOB_HISTORY> JOB_HISTORY { get; set; }
    }
}
