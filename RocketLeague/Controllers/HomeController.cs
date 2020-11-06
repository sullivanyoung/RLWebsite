using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RocketLeague.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RLEsports()
        {
            ViewBag.Message = "This page is dedicated to all things Rocket League";

            return View();
        }

        public ActionResult Liquipedia()
        {
            ViewBag.Message = "Page dedicated to RL Players and their statistics";

            return View();
        }
    }
}