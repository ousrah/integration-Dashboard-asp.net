using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication15;

namespace WebApplication15.Controllers
{
    public class ECRIVAINsController : Controller
    {
        private librairieEntities db = new librairieEntities();


        [HttpPost]
        public ActionResult getListeEcrivains(string mot)
        {
            var ecr = db.ECRIVAIN.Where(o => o.NOMECR.Contains(mot)).ToList();
            return PartialView("~/Views/ECRIVAINs/listeEcrivains.cshtml",ecr);
        }


        // GET: ECRIVAINs
        public ActionResult Index()
        {
            return View(db.ECRIVAIN.ToList());
        }

        // GET: ECRIVAINs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ECRIVAIN eCRIVAIN = db.ECRIVAIN.Find(id);
            if (eCRIVAIN == null)
            {
                return HttpNotFound();
            }
            return View(eCRIVAIN);
        }

        // GET: ECRIVAINs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ECRIVAINs/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NUMECR,PRENOMECR,NOMECR,PAYSECR,LANGUECR")] ECRIVAIN eCRIVAIN)
        {
            if (ModelState.IsValid)
            {
                db.ECRIVAIN.Add(eCRIVAIN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eCRIVAIN);
        }

        // GET: ECRIVAINs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ECRIVAIN eCRIVAIN = db.ECRIVAIN.Find(id);
            if (eCRIVAIN == null)
            {
                return HttpNotFound();
            }
            return View(eCRIVAIN);
        }

        // POST: ECRIVAINs/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NUMECR,PRENOMECR,NOMECR,PAYSECR,LANGUECR")] ECRIVAIN eCRIVAIN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eCRIVAIN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eCRIVAIN);
        }

        // GET: ECRIVAINs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ECRIVAIN eCRIVAIN = db.ECRIVAIN.Find(id);
            if (eCRIVAIN == null)
            {
                return HttpNotFound();
            }
            return View(eCRIVAIN);
        }

        // POST: ECRIVAINs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ECRIVAIN eCRIVAIN = db.ECRIVAIN.Find(id);
            db.ECRIVAIN.Remove(eCRIVAIN);
            db.SaveChanges();
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
