using ProjetoDotNetUnidade2.MVC.DDD.AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetoDotNetUnidade2.MVC.DDD
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //Subindo a aplicação
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Mapear as classes
            AutoMapperConfig.RegisterMappings();

        }
    }
}
