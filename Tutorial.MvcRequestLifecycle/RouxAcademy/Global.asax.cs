using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RouxAcademy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected DateTime requestStartTime;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Register custom controller factory
            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            // Register custom dependency resolver
            DependencyResolver.SetResolver(new CustomDependencyResolver());

            // Application state
            Application["ApplicationStartDateTime"] = DateTime.Now;
        }

        protected void Application_End()
        {
            Application.Clear();
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            requestStartTime = DateTime.Now;

            Trace.WriteLine(String.Format("Request Start Time: {0}", requestStartTime));
        }

        protected void Application_EndRequest(Object sender, EventArgs e)
        {
            TimeSpan totalRequestTime = DateTime.Now - requestStartTime;

            Trace.WriteLine(String.Format("Request Time: {0}ms", totalRequestTime.TotalMilliseconds));
        }
    }
}
