using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RouxAcademy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Application state
            Application["ApplicationStartDateTime"] = DateTime.Now;
        }

        protected void Application_End()
        {
            Application.Clear();
        }
    }
}
