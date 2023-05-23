using System.Web;
using System.Web.Mvc;

namespace OTEL_WEB_UYGULAMASI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
