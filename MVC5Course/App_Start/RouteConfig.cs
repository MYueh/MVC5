using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5Course
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            /*
             * http://localhost/Home/Cart.aspx?id=123
             */
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
             * http://api.jquery.com/jQuery.each/
             */
            routes.MapRoute(
                name: "Practics1",
                url: "{controller}.{action}.{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            /*
             * http://api.jquery.com/Docs/jQuery-each/
             */
            routes.MapRoute(
                name: "Practics2",
                url: "Docs/{controller}-{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Home", 
                    action = "Index", 
                    id = UrlParameter.Optional 
                }
            );
        }
    }
}
