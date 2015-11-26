namespace CodeFirstOracle.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.DEPARTMENTS")]
    public partial class DEPARTMENTS
    {
        public DEPARTMENTS()
        {
            EMPLOYEES1 = new HashSet<EMPLOYEES>();
            JOB_HISTORY = new HashSet<JOB_HISTORY>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string DEPARTMENT_NAME { get; set; }

        public int? MANAGER_ID { get; set; }

        public short? LOCATION_ID { get; set; }

        public virtual LOCATIONS LOCATIONS { get; set; }

        public virtual EMPLOYEES EMPLOYEES { get; set; }

        public virtual ICollection<EMPLOYEES> EMPLOYEES1 { get; set; }

        public virtual ICollection<JOB_HISTORY> JOB_HISTORY { get; set; }
    }
}
