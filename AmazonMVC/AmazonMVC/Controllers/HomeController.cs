﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazonMVC.Controllers
{
    //[AuthenticationFilter]
    public class HomeController : Controller
    {

        public ActionResult Logout()
        {
            if (Session["FirstName"] == null || Session == null)
            {
                return RedirectToAction("Create", "Register");
            }
            else
            {
                Session.Clear();
                Session.Abandon();

            }
            return RedirectToAction("Index", "Register");
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}