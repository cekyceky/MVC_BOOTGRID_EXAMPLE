using System.Web;
using System.Web.Mvc;

namespace MVC_Bootgrid_example
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
