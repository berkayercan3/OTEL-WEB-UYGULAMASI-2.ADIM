using OTEL_WEB_UYGULAMASI.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OTEL_WEB_UYGULAMASI.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public PartialViewResult ikonlar()
        {
            var deger = c.ikonlars.ToList();
            return PartialView(deger);
        }
    }
}