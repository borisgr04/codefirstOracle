namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.CAT_PROD")]
    public partial class CAT_PROD
    {
        public CAT_PROD()
        {
            CAP_PROD = new HashSet<CAP_PROD>();
            SCAT_PROD = new HashSet<SCAT_PROD>();
        }

        [Key]
        [StringLength(5)]
        public string COD_CAT { get; set; }

        [Required]
        [StringLength(30)]
        public string DES_CAT { get; set; }

        public virtual ICollection<CAP_PROD> CAP_PROD { get; set; }

        public virtual ICollection<SCAT_PROD> SCAT_PROD { get; set; }
    }
}
