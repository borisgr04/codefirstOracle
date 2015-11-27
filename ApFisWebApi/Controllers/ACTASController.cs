using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApFisWebApi.Models;
using ApFisWebApi.Models.DTO;

namespace ApFisWebApi.Controllers
{
    [RoutePrefix("api/actas")]
    public class ACTASController : ApiController
    {
        private ApFisContext db = new ApFisContext();

        // GET: api/ACTAS
        //actas?fi=2015-02-01&ff=2015-03-01&ide=113
        [Route("")]
        [ResponseType(typeof(IQueryable<VACTAS>))]
        public async Task<IHttpActionResult> GetACTAS(DateTime fi, DateTime ff, int? ide)
        {
            if (ide.HasValue)
            {
                return Ok(
                    await db.ACTAS.Where(t => t.ESTADO != "00" & t.FECHAINI >= fi && t.FECHAINI <= ff && t.CED_INF == ide)
                        .Select(SelectActa()
                    ).ToListAsync());
            }
            else {
                return Ok(
                    await db.ACTAS.Where(t => t.ESTADO != "00" & t.FECHAINI >= fi && t.FECHAINI <= ff )
                        .Select(SelectActa()
                    ).ToListAsync());
            }
        }

        private static System.Linq.Expressions.Expression<Func<ACTAS, VACTAS>> SelectActa()
        {
            return t => new VACTAS
            {
                NROACTA = t.NROACTA,
                FECHAINICIO = t.FECHAINI,
                IDE_INFRACT = t.CED_INF,
                ESTABLECIMIENTO = t.ESTABLEC.NOM_EST,
                INFRACT = t.INFRACTOR.NOM_INF + " " + t.INFRACTOR.APE1_INF + " " + t.INFRACTOR.APE2_INF,
                DIR_ESTA = t.ESTABLEC.DIR_EST,
                MUNICIPIO = t.MUNICIPIOS.NOM_MUN,
                BODEGA = t.BODEGAS.NOM_BOD,
                APREPOR = t.APREPOR,
                TIPOAPRE = t.TIPOAPRE,
                CAUSALES = t.CAUSALES,
                ESTADO= t.ESTADO,
                Documentos = t.ESTACTAS.Select(tt => new VACTASDOC
                {
                    FECHA = tt.FECHA,
                    FMTO_EST = tt.FMTO_EST,
                    ESTADO = tt.ESTADO,
                    NROACTA = tt.NROACTA
                }).ToList(),
                Productos = t.PRODACTAS.Select(pp => new VPRODACTAS {
                     CODIGO=pp.CODIGO,
                     NOMBRE = pp.PRODUCTOS.DESCRIPCION,
                     UNIDADES = pp.UNIDADES,
                     CAPACIDAD = pp.PRODUCTOS.CAP_PROD1.DES_CAP,
                     PRECIOUNIT= pp.PRECIOUNIT
                }).ToList()
            };
        }

        //[Route("{id}/documentos")]
        //[ResponseType(typeof(IQueryable<VACTAS>))]
        //public async Task<IHttpActionResult> GetDocumentos(long id)
        //{
        //    return Ok(
        //            await db.ESTACTAS.Where(t => t.NROACTA == id)
        //                .Select(
        //                t => new VACTASDOC { 
        //                     FECHA = t.FECHA,
        //                     FMTO_EST = t.FMTO_EST,
        //                     ESTADO= t.ESTADO,
        //                     NROACTA = t.NROACTA
        //                }
        //            ).ToListAsync());
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}