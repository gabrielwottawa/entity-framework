using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicMVC.Context;
using MusicMVC.Models;

namespace MusicMVC.Controllers
{
    public class Artists_GenresController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Artists_Genres
        public ActionResult Index()
        {
            var artists_Genres = db.Artists_Genres.Include(a => a.Artist).Include(a => a.Genres);
            return View(artists_Genres.ToList());
        }

        // GET: Artists_Genres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artists_Genres artists_Genres = db.Artists_Genres.Find(id);
            if (artists_Genres == null)
            {
                return HttpNotFound();
            }
            return View(artists_Genres);
        }

        // GET: Artists_Genres/Create
        public ActionResult Create()
        {
            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName");
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName");
            return View();
        }

        // POST: Artists_Genres/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Artists_GenresID,GenreID,ArtistID")] Artists_Genres artists_Genres)
        {
            if (ModelState.IsValid)
            {
                db.Artists_Genres.Add(artists_Genres);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", artists_Genres.ArtistID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName", artists_Genres.GenreID);
            return View(artists_Genres);
        }

        // GET: Artists_Genres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artists_Genres artists_Genres = db.Artists_Genres.Find(id);
            if (artists_Genres == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", artists_Genres.ArtistID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName", artists_Genres.GenreID);
            return View(artists_Genres);
        }

        // POST: Artists_Genres/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Artists_GenresID,GenreID,ArtistID")] Artists_Genres artists_Genres)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artists_Genres).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", artists_Genres.ArtistID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName", artists_Genres.GenreID);
            return View(artists_Genres);
        }

        // GET: Artists_Genres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artists_Genres artists_Genres = db.Artists_Genres.Find(id);
            if (artists_Genres == null)
            {
                return HttpNotFound();
            }
            return View(artists_Genres);
        }

        // POST: Artists_Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artists_Genres artists_Genres = db.Artists_Genres.Find(id);
            db.Artists_Genres.Remove(artists_Genres);
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
