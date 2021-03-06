﻿using System;
using System.Web.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var optional = RouteData.Values["id"];

            var message = String.Format("{0}::{1} {2}", controller, action, optional);

            ViewBag.Message = message;

            return View();
        }

        public ActionResult Ideas()
        {
            ViewBag.Message = "Share ideas here.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
