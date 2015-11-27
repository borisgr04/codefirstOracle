namespace ApFisWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.PAGAUT")]
    public partial class PAGAUT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_PER { get; set; }

        [Required]
        [StringLength(40)]
        public string NOM_PAG { get; set; }
    }
}
