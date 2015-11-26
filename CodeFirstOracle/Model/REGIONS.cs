namespace CodeFirstOracle.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.REGIONS")]
    public partial class REGIONS
    {
        public REGIONS()
        {
            COUNTRIES = new HashSet<COUNTRIES>();
        }

        [Key]
        public decimal REGION_ID { get; set; }

        [StringLength(25)]
        public string REGION_NAME { get; set; }

        public virtual ICollection<COUNTRIES> COUNTRIES { get; set; }
    }
}
