using System.Web;
using System.Web.Mvc;

namespace Web_Lab01c_HTMLl
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
