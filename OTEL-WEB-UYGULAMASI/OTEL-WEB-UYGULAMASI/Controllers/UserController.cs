using OTEL_WEB_UYGULAMASI.Models.Siniflar;
using System;
using OTEL_WEB_UYGULAMASI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OTEL_WEB_UYGULAMASI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        Context db = new Context();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcıyı veritabanına kaydetme işlemleri burada gerçekleştirilir
                using (var db = new Context())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                TempData["SuccessMessage"] = "Kaydınız başarılı bir şekilde oluşturuldu.Giriş sayfasından girişinizi gerçekleştirebilirsiniz";
                // Kayıt işlemi başarılıysa, kullanıcıyı başka bir sayfaya yönlendirin
                return RedirectToAction("Index","AnaSayfa");
            }

            // Hatalı giriş durumunda aynı sayfayı göster ve hataları göster
            return View(model);


        }
    }
}