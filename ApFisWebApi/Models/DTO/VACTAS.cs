using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApFisWebApi.Models.DTO
{
    public class VACTAS
    {
        public long NROACTA {get; set;}
        public DateTime FECHAINICIO {get; set;}
        public string ESTABLECIMIENTO {get; set;}
        public long IDE_INFRACT { get; set; }
        public string INFRACT {get; set;}
        public string DIR_ESTA {get; set;}
        public string MUNICIPIO {get; set;}
        public string BODEGA { get; set; }
        public string APREPOR {get; set;}
        public string TIPOAPRE {get; set;}
        public string CAUSALES {get; set;}
        public string ESTADO { get; set; }
        public List<VACTASDOC> Documentos { get; set; }
        public List<VPRODACTAS> Productos { get; set; }
    }

    public class VACTASDOC
    {
        public long NROACTA { get; set; }
        public DateTime FECHA { get; set; }
        public string FMTO_EST { get; set; }
        public string ESTADO { get; set; }
      
    }

    public class VPRODACTAS
    {
        public long NROACTA { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public long UNIDADES { get; set; }
        public long PRECIOUNIT { get; set; }
        public string ESTADO { get; set; }
        public long PRODSAL { get; set; }
        public string CAPACIDAD { get; set; }
    }
      
}