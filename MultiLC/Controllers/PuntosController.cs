using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MultiLC.Context;
using MultiLC.Models;

namespace MultiLC.Controllers
{
    public class PuntosController : Controller
    {
        private MultiContext db = new MultiContext();

        // GET: Puntos
        public ActionResult Index()
        {
            return View(db.Puntos.ToList());
        }

        // GET: Puntos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Puntos puntos = db.Puntos.Find(id);
            if (puntos == null)
            {
                return HttpNotFound();
            }
            return View(puntos);
        }

        // GET: Puntos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Puntos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPuntos,Cantidad,FechaAsignados,TipoPunto")] Puntos puntos)
        {
            if (ModelState.IsValid)
            {
                db.Puntos.Add(puntos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(puntos);
        }

        // GET: Puntos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Puntos puntos = db.Puntos.Find(id);
            if (puntos == null)
            {
                return HttpNotFound();
            }
            return View(puntos);
        }

        // POST: Puntos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPuntos,Cantidad,FechaAsignados,TipoPunto")] Puntos puntos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(puntos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(puntos);
        }

        // GET: Puntos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Puntos puntos = db.Puntos.Find(id);
            if (puntos == null)
            {
                return HttpNotFound();
            }
            return View(puntos);
        }

        // POST: Puntos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Puntos puntos = db.Puntos.Find(id);
            db.Puntos.Remove(puntos);
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
