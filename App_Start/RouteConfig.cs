using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Final
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            // detail sp
            routes.MapRoute("detailProduct", "{type}/{meta}/{name}",
                new { controller = "product", action = "detail", name = UrlParameter.Optional },
                new RouteValueDictionary
                {
                    {"type", "products" }
                },
                new[] { "final.controllers" });

            // detail blog
            routes.MapRoute("blog", "{type}/{meta}/{name}",
                new { controller = "BLOG", action = "detailBLOG", name = UrlParameter.Optional },
                new RouteValueDictionary
                {
                    {"type", "Blog" }
                },
                new[] { "final.controllers" });

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //add to cart
            routes.MapRoute(
                name: "Add to cart",
                url: "them-gio-hang",
                defaults: new { Controller = "ShoppingCart", Action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] {"Final.Controllers"}
                );


            //
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
