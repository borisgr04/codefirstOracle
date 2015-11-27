namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.CAP_PROD")]
    public partial class CAP_PROD
    {
        public CAP_PROD()
        {
            PRODUCTOS = new HashSet<PRODUCTOS>();
        }

        [Key]
        [StringLength(5)]
        public string COD_CAP { get; set; }

        [Required]
        [StringLength(30)]
        public string DES_CAP { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_CAT { get; set; }

        [StringLength(100)]
        public string PRE_FND { get; set; }

        public virtual CAT_PROD CAT_PROD { get; set; }

        public virtual ICollection<PRODUCTOS> PRODUCTOS { get; set; }
    }
}
