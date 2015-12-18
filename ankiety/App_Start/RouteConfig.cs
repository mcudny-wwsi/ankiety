using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ankiety
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{ankietaId}/{stazId}/{studentId}",
                defaults: new { controller = "Home", action = "Ankieta", ankietaId = UrlParameter.Optional, stazId = UrlParameter.Optional, studentId = UrlParameter.Optional }
            );
        }
    }
}
