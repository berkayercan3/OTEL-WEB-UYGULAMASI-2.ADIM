using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OTEL_WEB_UYGULAMASI.Models.Siniflar
{
    public class Rezervasyon
    {
        [Key]
        public int RezervasyonId { get; set; }

        // Rezervasyon bilgileri için diğer özellikleri buraya ekleyin
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        // vb.

        // Diğer ilişkisel özellikler ve yöntemler buraya eklenebilir
    }
}