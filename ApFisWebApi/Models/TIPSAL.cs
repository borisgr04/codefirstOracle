namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.TIPSAL")]
    public partial class TIPSAL
    {
        [Key]
        [StringLength(6)]
        public string COD_SAL { get; set; }

        [StringLength(30)]
        public string DES_SAL { get; set; }
    }
}
