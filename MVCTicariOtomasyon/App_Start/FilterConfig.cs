using System.Web;
using System.Web.Mvc;

namespace MVCTicariOtomasyon
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
