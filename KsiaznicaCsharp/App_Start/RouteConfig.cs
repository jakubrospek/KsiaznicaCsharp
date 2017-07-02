using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KsiaznicaCsharp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "SignIn",
                url: "Account/SignIn/{id}",
                defaults: new { controller = "Account", action = "SignIn", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "LogIn", id = UrlParameter.Optional }
            );

            /*
            routes.MapRoute(
                name: "temporary",
                url: "Home/temporary/{id}",
                defaults: new { controller = "Home", action = "temporary", id = UrlParameter.Optional }
            );*/

        }
    }
}
