using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApFisWebApi.Models;
using ApFisWebApi.Models.DTO;

namespace ApFisWebApi.Controllers
{
    public class ACTAS1Controller : Controller
    {
        //meloxican
        private ApFisContext db = new ApFisContext();

        // GET: ACTAS1
        public async Task<ActionResult> Index()
        {
            Dictionary<string, string> Estados = new Dictionary<string,string>();
            
            Estados.Add("01", "INGRESADA");
            Estados.Add("02", "PLIEGO DE CARGO");
            Estados.Add("03", "RESOLUCION DE DECOMISO");
            Estados.Add("04", "RESOLUCIÓN DE DEVOLUCIÓN");
            Estados.Add("05", "RESOLUCION QUE FALLA RECURSO DE RECONSIDERACION");
            Estados.Add("06", "CONSTANCIA EJECUTORIA");

            return View(await db.ACTAS.Where(t=>t.ESTADO!= "00")
                .Select(t => new VACTAS
                {
                    NROACTA = t.NROACTA,
                    FECHAINICIO = t.FECHAINI,
                    IDE_INFRACT = t.CED_INF,
                    ESTABLECIMIENTO = t.ESTABLEC.NOM_EST,
                    INFRACT = t.INFRACTOR.NOM_INF + " " + t.INFRACTOR.APE1_INF + " " + t.INFRACTOR.NOM_INF,
                    DIR_ESTA = t.ESTABLEC.DIR_EST,
                    MUNICIPIO = t.MUNICIPIOS.NOM_MUN,
                    BODEGA = t.BODEGAS.NOM_BOD,
                    APREPOR = t.APREPOR,
                    TIPOAPRE = t.TIPOAPRE,
                    CAUSALES = t.CAUSALES
                    //,ESTADO = Estados[t.ESTADO]
                }
                ).ToListAsync()
             );
        }

        // GET: ACTAS1/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACTAS aCTAS = await db.ACTAS.FindAsync(id);
            if (aCTAS == null)
            {
                return HttpNotFound();
            }
            return View(aCTAS);
        }

        // GET: ACTAS1/Create
        public ActionResult Create()
        {
            ViewBag.COD_BOD = new SelectList(db.BODEGAS, "COD_BOD", "NOM_BOD");
            ViewBag.IDE_COOR = new SelectList(db.CGOPERATIVO, "CED_CGO", "APE1_CGO");
            ViewBag.NIT_EST = new SelectList(db.ESTABLEC, "NIT_EST", "NOM_EST");
            ViewBag.CED_INF = new SelectList(db.INFRACTOR, "CED_INF", "APE1_INF");
            ViewBag.COD_MUN = new SelectList(db.MUNICIPIOS, "COD_MUN", "NOM_MUN");
            ViewBag.IDE_AUTORIDAD = new SelectList(db.RAUTORIDAD, "CED_AUT", "APE1_AUT");
            ViewBag.IDE_BODEGA = new SelectList(db.RBODEGA, "CED_BOD", "APE1_BOD");
            ViewBag.USUARIO = new SelectList(db.USUARIOS, "USERNAME", "PASSWORD");
            return View();
        }

        // POST: ACTAS1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "NROACTA,FECHAINI,FECHAFIN,FACTURA,OTRODOC,CED_INF,TOTALUNID,EXPLICACION,REL_FACTCOM,REL_MANCARGA,REL_OTROS,REL_FACTCOM_FOLIO,REL_MANCARGA_FOLIO,REL_OTROS_FOLIO,IDE_COOR,IDE_AUTORIDAD,IDE_BODEGA,ESTADO,FIRMA,USUARIO,FEC_REG,FCOOR,FAUT,FINF,FBOD,COD_BOD,COD_MUN,NIT_EST,TIPOAPRE,CAUSALES,APREPOR,FECPOL,CATPROD,TIP_RES,PRU_CON,NRO_NOT,EMP_NOT,FEC_NOT,ARG_CON,NRO_NOTD,EMP_NOTD,FEC_NOTD,FEC_VEND,TIP_NOT,TIP_NOTR,FEC_NOTP_RR,SEDEMOSTRO,TIEMCIERRE")] ACTAS aCTAS)
        {
            if (ModelState.IsValid)
            {
                db.ACTAS.Add(aCTAS);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.COD_BOD = new SelectList(db.BODEGAS, "COD_BOD", "NOM_BOD", aCTAS.COD_BOD);
            ViewBag.IDE_COOR = new SelectList(db.CGOPERATIVO, "CED_CGO", "APE1_CGO", aCTAS.IDE_COOR);
            ViewBag.NIT_EST = new SelectList(db.ESTABLEC, "NIT_EST", "NOM_EST", aCTAS.NIT_EST);
            ViewBag.CED_INF = new SelectList(db.INFRACTOR, "CED_INF", "APE1_INF", aCTAS.CED_INF);
            ViewBag.COD_MUN = new SelectList(db.MUNICIPIOS, "COD_MUN", "NOM_MUN", aCTAS.COD_MUN);
            ViewBag.IDE_AUTORIDAD = new SelectList(db.RAUTORIDAD, "CED_AUT", "APE1_AUT", aCTAS.IDE_AUTORIDAD);
            ViewBag.IDE_BODEGA = new SelectList(db.RBODEGA, "CED_BOD", "APE1_BOD", aCTAS.IDE_BODEGA);
            ViewBag.USUARIO = new SelectList(db.USUARIOS, "USERNAME", "PASSWORD", aCTAS.USUARIO);
            return View(aCTAS);
        }

        // GET: ACTAS1/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACTAS aCTAS = await db.ACTAS.FindAsync(id);
            if (aCTAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.COD_BOD = new SelectList(db.BODEGAS, "COD_BOD", "NOM_BOD", aCTAS.COD_BOD);
            ViewBag.IDE_COOR = new SelectList(db.CGOPERATIVO, "CED_CGO", "APE1_CGO", aCTAS.IDE_COOR);
            ViewBag.NIT_EST = new SelectList(db.ESTABLEC, "NIT_EST", "NOM_EST", aCTAS.NIT_EST);
            ViewBag.CED_INF = new SelectList(db.INFRACTOR, "CED_INF", "APE1_INF", aCTAS.CED_INF);
            ViewBag.COD_MUN = new SelectList(db.MUNICIPIOS, "COD_MUN", "NOM_MUN", aCTAS.COD_MUN);
            ViewBag.IDE_AUTORIDAD = new SelectList(db.RAUTORIDAD, "CED_AUT", "APE1_AUT", aCTAS.IDE_AUTORIDAD);
            ViewBag.IDE_BODEGA = new SelectList(db.RBODEGA, "CED_BOD", "APE1_BOD", aCTAS.IDE_BODEGA);
            ViewBag.USUARIO = new SelectList(db.USUARIOS, "USERNAME", "PASSWORD", aCTAS.USUARIO);
            return View(aCTAS);
        }

        // POST: ACTAS1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "NROACTA,FECHAINI,FECHAFIN,FACTURA,OTRODOC,CED_INF,TOTALUNID,EXPLICACION,REL_FACTCOM,REL_MANCARGA,REL_OTROS,REL_FACTCOM_FOLIO,REL_MANCARGA_FOLIO,REL_OTROS_FOLIO,IDE_COOR,IDE_AUTORIDAD,IDE_BODEGA,ESTADO,FIRMA,USUARIO,FEC_REG,FCOOR,FAUT,FINF,FBOD,COD_BOD,COD_MUN,NIT_EST,TIPOAPRE,CAUSALES,APREPOR,FECPOL,CATPROD,TIP_RES,PRU_CON,NRO_NOT,EMP_NOT,FEC_NOT,ARG_CON,NRO_NOTD,EMP_NOTD,FEC_NOTD,FEC_VEND,TIP_NOT,TIP_NOTR,FEC_NOTP_RR,SEDEMOSTRO,TIEMCIERRE")] ACTAS aCTAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCTAS).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.COD_BOD = new SelectList(db.BODEGAS, "COD_BOD", "NOM_BOD", aCTAS.COD_BOD);
            ViewBag.IDE_COOR = new SelectList(db.CGOPERATIVO, "CED_CGO", "APE1_CGO", aCTAS.IDE_COOR);
            ViewBag.NIT_EST = new SelectList(db.ESTABLEC, "NIT_EST", "NOM_EST", aCTAS.NIT_EST);
            ViewBag.CED_INF = new SelectList(db.INFRACTOR, "CED_INF", "APE1_INF", aCTAS.CED_INF);
            ViewBag.COD_MUN = new SelectList(db.MUNICIPIOS, "COD_MUN", "NOM_MUN", aCTAS.COD_MUN);
            ViewBag.IDE_AUTORIDAD = new SelectList(db.RAUTORIDAD, "CED_AUT", "APE1_AUT", aCTAS.IDE_AUTORIDAD);
            ViewBag.IDE_BODEGA = new SelectList(db.RBODEGA, "CED_BOD", "APE1_BOD", aCTAS.IDE_BODEGA);
            ViewBag.USUARIO = new SelectList(db.USUARIOS, "USERNAME", "PASSWORD", aCTAS.USUARIO);
            return View(aCTAS);
        }

        // GET: ACTAS1/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACTAS aCTAS = await db.ACTAS.FindAsync(id);
            if (aCTAS == null)
            {
                return HttpNotFound();
            }
            return View(aCTAS);
        }

        // POST: ACTAS1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            ACTAS aCTAS = await db.ACTAS.FindAsync(id);
            db.ACTAS.Remove(aCTAS);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

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
