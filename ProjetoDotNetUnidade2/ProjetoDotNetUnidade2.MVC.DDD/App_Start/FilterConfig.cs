using System.Web;
using System.Web.Mvc;

namespace ProjetoDotNetUnidade2.MVC.DDD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
