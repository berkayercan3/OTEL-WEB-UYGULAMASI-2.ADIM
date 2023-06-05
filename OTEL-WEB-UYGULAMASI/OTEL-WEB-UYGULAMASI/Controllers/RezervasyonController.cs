using System;
using System.Linq;
using System.Web.Mvc;
using OTEL_WEB_UYGULAMASI.Models.Siniflar;

namespace OTEL_WEB_UYGULAMASI.Controllers
{
    public class RezervasyonController : Controller
    {
        private Context _context;

        public RezervasyonController()
        {
            _context = new Context();
        }

        public ActionResult Index()
        {
            var rezervasyonlar = _context.Rezervasyonlar.ToList();

            return View(rezervasyonlar);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                _context.Rezervasyonlar.Add(rezervasyon);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rezervasyon);
        }

        public ActionResult Edit(int id)
        {
            var rezervasyon = _context.Rezervasyonlar.Find(id);

            if (rezervasyon == null)
            {
                return HttpNotFound();
            }

            return View(rezervasyon);
        }

        [HttpPost]
        public ActionResult Edit(Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(rezervasyon).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rezervasyon);
        }

        public ActionResult Delete(int id)
        {
            var rezervasyon = _context.Rezervasyonlar.Find(id);

            if (rezervasyon == null)
            {
                return HttpNotFound();
            }

            return View(rezervasyon);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var rezervasyon = _context.Rezervasyonlar.Find(id);

            if (rezervasyon == null)
            {
                return HttpNotFound();
            }

            _context.Rezervasyonlar.Remove(rezervasyon);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KullaniciBilgileri(int id)
        {
            var kullanici = _context.Users.Find(id);

            if (kullanici == null)
            {
                return HttpNotFound();
            }

            return View(kullanici);
        }
    }
}
