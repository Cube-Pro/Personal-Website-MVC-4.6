using System.Web;
using System.Web.Mvc;

namespace Personal_Website_MVC_4._6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
