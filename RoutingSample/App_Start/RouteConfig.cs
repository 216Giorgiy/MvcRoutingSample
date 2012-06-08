﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "ProductIndex",
            //    url: "{controller}/{action}",
            //    defaults: new 
            //    { 
            //        controller = "Product", 
            //        action = "Index" 
            //    }
            //);

            routes.MapRoute(
                name: "FilterProductIndex",
                url: "{controller}/{action}/{category}/{name}",
                defaults: new
                {
                    controller = "Product",
                    action = "Index",
                    category = UrlParameter.Optional,
                    name = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}