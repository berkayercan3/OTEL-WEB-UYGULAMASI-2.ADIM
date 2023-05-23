using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OTEL_WEB_UYGULAMASI.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
    }
}