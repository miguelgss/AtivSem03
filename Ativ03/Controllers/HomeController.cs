using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ativ03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Credits()
        {
            ViewBag.Message = "All credits reserved to BANDAI and Akiyoshi Hongo.";

            return View();
        }
    }
}