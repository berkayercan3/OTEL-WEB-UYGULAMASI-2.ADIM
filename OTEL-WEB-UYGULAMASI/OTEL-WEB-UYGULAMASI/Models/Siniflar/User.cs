using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OTEL_WEB_UYGULAMASI.Models.Siniflar
{
    public class User
    {
        [Key]
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string Password { get; set; }
    }
}