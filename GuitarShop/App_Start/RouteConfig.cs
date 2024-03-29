﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GuitarShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Product List",
                url: "san-pham/{Metadata}-{id}",
                defaults: new { controller = "Category", action = "ProductList", id = UrlParameter.Optional },
                namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
                name: "Search",
                url: "tim-kiem",
                defaults: new { controller = "Search", action = "SearchResult", id = UrlParameter.Optional },
                namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
                name: "Product Detail",
                url: "chi-tiet/{Metadata}-{id}",
                defaults: new { controller = "Product", action = "ProductDetail", id = UrlParameter.Optional },
                namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
                name: "Cart Detail",
                url: "gio-hang",
                defaults: new { controller = "Cart", action = "CartDetail", id = UrlParameter.Optional },
                namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
                name: "Add Cart Item",
                url: "them-gio-hang",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
               name: "Checkout",
               url: "thanh-toan",
               defaults: new { controller = "Cart", action = "Checkout", id = UrlParameter.Optional },
               namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
               name: "Login",
               url: "dang-nhap",
               defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional },
               namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
               name: "Register",
               url: "dang-ki",
               defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional },
               namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
               name: "Contact",
               url: "lien-he",
               defaults: new { controller = "Contact", action = "Contact", id = UrlParameter.Optional },
               namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
               name: "About",
               url: "gioi-thieu",
               defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional },
               namespaces: new[] { "GuitarShop.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "GuitarShop.Controllers" });
        }
    }
}
