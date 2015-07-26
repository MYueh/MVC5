using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;

namespace MVC5Course.Controllers
{
    public class OccupationsController : Controller
    {
        private FabricsEntities db = new FabricsEntities();

        // GET: Occupations
        public ActionResult Index()
        {
            return View(db.Occupation.ToList());
        }

        // GET: Occupations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Occupation occupation = db.Occupation.Find(id);
            if (occupation == null)
            {
                return HttpNotFound();
            }
            return View(occupation);
        }

        // GET: Occupations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Occupations/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OccupationId,OccupationName")] Occupation occupation)
        {
            if (ModelState.IsValid)
            {
                db.Occupation.Add(occupation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(occupation);
        }

        // GET: Occupations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Occupation occupation = db.Occupation.Find(id);
            if (occupation == null)
            {
                return HttpNotFound();
            }
            return View(occupation);
        }

        // POST: Occupations/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OccupationId,OccupationName")] Occupation occupation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(occupation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(occupation);
        }

        // GET: Occupations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Occupation occupation = db.Occupation.Find(id);
            if (occupation == null)
            {
                return HttpNotFound();
            }
            return View(occupation);
        }

        // POST: Occupations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Occupation occupation = db.Occupation.Find(id);
            db.Occupation.Remove(occupation);
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
