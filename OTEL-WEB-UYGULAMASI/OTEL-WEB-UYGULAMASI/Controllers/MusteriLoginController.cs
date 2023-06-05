using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTEL_WEB_UYGULAMASI.Models.Siniflar;


namespace OTEL_WEB_UYGULAMASI.Controllers
{
    public class MusteriLoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        private Context _context;
        public MusteriLoginController()
        {
            _context = new Context();
        }

        // Diğer action metodları burada bulunur

        // Giriş işlemi için action metodu
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Kullanıcıyı veritabanında arayın
            var user = _context.Users.FirstOrDefault(u => u.username == username && u.Password == password);

            if (user != null)
            {
                // Giriş başarılı
                // Oturumu aç veya gerekli işlemleri yap
                return Redirect("https://localhost:44313/Rezervasyon/Index");
            }
            else
            {
                // Giriş başarısız
                // Hata mesajı döndür veya giriş sayfasını tekrar göster
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre yanlış";
                return View("Index");
            }
        }
    }
}