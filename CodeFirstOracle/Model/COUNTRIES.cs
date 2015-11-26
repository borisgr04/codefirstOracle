namespace CodeFirstOracle.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.COUNTRIES")]
    public partial class COUNTRIES
    {
        public COUNTRIES()
        {
            LOCATIONS = new HashSet<LOCATIONS>();
        }

        [Key]
        [StringLength(2)]
        public string COUNTRY_ID { get; set; }

        [StringLength(40)]
        public string COUNTRY_NAME { get; set; }

        public decimal? REGION_ID { get; set; }

        public virtual REGIONS REGIONS { get; set; }

        public virtual ICollection<LOCATIONS> LOCATIONS { get; set; }
    }
}
