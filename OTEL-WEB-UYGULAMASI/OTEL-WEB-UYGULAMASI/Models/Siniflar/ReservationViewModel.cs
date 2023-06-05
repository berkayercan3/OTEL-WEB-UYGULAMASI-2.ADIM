using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OTEL_WEB_UYGULAMASI.Models.Siniflar;
using System.Collections.Generic;

namespace OTEL_WEB_UYGULAMASI.Models.Siniflar
{
    public class ReservationViewModel
    {
        public User User { get; set; }
        public List<Rezervasyon> Reservations { get; set; }
    }
}