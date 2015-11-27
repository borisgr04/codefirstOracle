namespace CodeFirstOracle.Model.Apfis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APFIS.TIPO_FND")]
    public partial class TIPO_FND
    {
        [Key]
        [StringLength(4)]
        public string COD_TIP { get; set; }

        [StringLength(50)]
        public string NOM_TIP { get; set; }
    }
}
