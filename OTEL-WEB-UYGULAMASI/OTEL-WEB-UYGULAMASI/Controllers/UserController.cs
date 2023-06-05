using OTEL_WEB_UYGULAMASI.Models;
using OTEL_WEB_UYGULAMASI.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OTEL_WEB_UYGULAMASI.Controllers
{
    public class UserController : Controller
    {
        private Context _context;

        public UserController()
        {
            _context = new Context();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(model);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Kaydınız başarılı bir şekilde oluşturuldu. Giriş sayfasından girişinizi gerçekleştirebilirsiniz.";
                return RedirectToAction("Index", "AnaSayfa");
            }

            return View(model);
        }

        public ActionResult GetUser(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.username == username);

            if (user == null)
            {
                return HttpNotFound();
            }

            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}
