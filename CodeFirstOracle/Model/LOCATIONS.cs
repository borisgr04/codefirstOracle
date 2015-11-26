namespace CodeFirstOracle.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.LOCATIONS")]
    public partial class LOCATIONS
    {
        public LOCATIONS()
        {
            DEPARTMENTS = new HashSet<DEPARTMENTS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION_ID { get; set; }

        [StringLength(40)]
        public string STREET_ADDRESS { get; set; }

        [StringLength(12)]
        public string POSTAL_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string CITY { get; set; }

        [StringLength(25)]
        public string STATE_PROVINCE { get; set; }

        [StringLength(2)]
        public string COUNTRY_ID { get; set; }

        public virtual COUNTRIES COUNTRIES { get; set; }

        public virtual ICollection<DEPARTMENTS> DEPARTMENTS { get; set; }
    }
}
