namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.SCAT_PROD")]
    public partial class SCAT_PROD
    {
        public SCAT_PROD()
        {
            PRODUCTOS = new HashSet<PRODUCTOS>();
        }

        [Key]
        [StringLength(5)]
        public string COD_SCAT { get; set; }

        [Required]
        [StringLength(30)]
        public string DES_SCAT { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_CAT { get; set; }

        [StringLength(20)]
        public string COD_FND { get; set; }

        [StringLength(20)]
        public string COD_SCAT_ANT { get; set; }

        public virtual CAT_PROD CAT_PROD { get; set; }

        public virtual ICollection<PRODUCTOS> PRODUCTOS { get; set; }
    }
}
