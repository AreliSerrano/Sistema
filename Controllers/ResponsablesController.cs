using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sistema_Incidencias.Models;

namespace Sistema_Incidencias.Controllers
{
    public class ResponsablesController : Controller
    {
        private Sistema_IncidenciasEntities db = new Sistema_IncidenciasEntities();

        // GET: Responsables
        public ActionResult Index()
        {
            return View(db.Responsable.ToList());
        }

        // GET: Responsables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responsable responsable = db.Responsable.Find(id);
            if (responsable == null)
            {
                return HttpNotFound();
            }
            return View(responsable);
        }

        // GET: Responsables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Responsables/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_responsable,Nombre,Email,Cargo,Activo")] Responsable responsable)
        {
            if (ModelState.IsValid)
            {
                db.Responsable.Add(responsable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(responsable);
        }

        // GET: Responsables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responsable responsable = db.Responsable.Find(id);
            if (responsable == null)
            {
                return HttpNotFound();
            }
            return View(responsable);
        }

        // POST: Responsables/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_responsable,Nombre,Email,Cargo,Activo")] Responsable responsable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(responsable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(responsable);
        }

        // GET: Responsables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responsable responsable = db.Responsable.Find(id);
            if (responsable == null)
            {
                return HttpNotFound();
            }
            return View(responsable);
        }

        // POST: Responsables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Responsable responsable = db.Responsable.Find(id);
            db.Responsable.Remove(responsable);
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
