using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RocketLeague.Controllers
{
    public class LiquipediaController : Controller
    {
        public ActionResult Teams()
        {
            return View();
        }
        public ActionResult Player()
        {
            ViewBag.Message = "Player Page";
            return View();
        }

        public ActionResult PlayerRegistration()
        {
            ViewBag.Message = "Player Registration Page";
            return View();
        }
    }
}