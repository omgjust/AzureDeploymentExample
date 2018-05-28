using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = Commons.s1;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = Commons.s1;

            return View();
        }
    }
}