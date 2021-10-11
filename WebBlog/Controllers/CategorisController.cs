using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class CategorisController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Categoris
        public ActionResult Index()
        {
            var kategoriler = db.Kategoriler
                .Select(i => new CategorModel()
                {
                    Id=i.Id,
                    KategoriAdi = i.KategoriAdi,
                    BlogSayisi = i.Bloglar.Count()
                }) ;
            return View(kategoriler.ToList());
        }

        // GET: Categoris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categori categori = db.Kategoriler.Find(id);
            if (categori == null)
            {
                return HttpNotFound();
            }
            return View(categori);
        }

        // GET: Categoris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KategoriAdi")] Categori categori)
        {
            if (ModelState.IsValid)
            {
                db.Kategoriler.Add(categori);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categori);
        }

        // GET: Categoris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categori categori = db.Kategoriler.Find(id);
            if (categori == null)
            {
                return HttpNotFound();
            }
            return View(categori);
        }

        // POST: Categoris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,KategoriAdi")] Categori categori)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categori).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categori);
        }

        // GET: Categoris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categori categori = db.Kategoriler.Find(id);
            if (categori == null)
            {
                return HttpNotFound();
            }
            return View(categori);
        }

        // POST: Categoris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categori categori = db.Kategoriler.Find(id);
            db.Kategoriler.Remove(categori);
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
