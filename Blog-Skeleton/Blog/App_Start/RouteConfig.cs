﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            System.Console.WriteLine("0000000000000000000000000000000000000000000000");
            System.Console.WriteLine("0000000000000000000000000000000000000000000000");
            System.Console.WriteLine("0000000000000000000000000000000000000000000000");
            System.Console.WriteLine("0000000000000000000000000000000000000000000000");
            System.Console.WriteLine("0000000000000000000000000000000000000000000000");
            System.Console.WriteLine("0000000000000000000000000000000000000000000000");



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
