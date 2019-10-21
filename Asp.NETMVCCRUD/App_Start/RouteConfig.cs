using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Asp.NETMVCCRUD
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Menu", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Atividade",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Atividade", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
               name: "Postagem",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Postagem", action = "Index", id = UrlParameter.Optional }
           );

            
        }
    }
}
