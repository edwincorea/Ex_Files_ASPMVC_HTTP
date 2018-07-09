using System.Web.Mvc;
using System.Web.Routing;

namespace RouxAcademy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{*allrss}", new { allrss = @".*\.rss(/.*)?" });

            // Map attribute-defined routes
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "AcademicDetail",
                url: "Academics/Detail/{id}",
                defaults: new
                {
                    controller = "Home",
                    acttion = "ProgramDetail",
                    id = UrlParameter.Optional
                },
                constraints: new { id = @"\d+"}
            );

            routes.MapRoute(
                name: "Academics",
                url: "Academics",
                defaults: new
                {
                    controller = "Home",
                    action = "Programs"
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
