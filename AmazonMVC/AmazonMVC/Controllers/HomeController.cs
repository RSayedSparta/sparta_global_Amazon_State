using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazonMVC.Controllers
{
    
    public class HomeController : Controller
    {

        public ActionResult Logout()
        {
            if (Session["FirstName"] == null || Session == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Session.Clear();
                Session.Abandon();

            }
            return RedirectToAction("Create", "Register");
        }

        [AuthenticationFilter]
        public ActionResult Index()
        {
            return View();
        }
        [AuthenticationFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AuthenticationFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}