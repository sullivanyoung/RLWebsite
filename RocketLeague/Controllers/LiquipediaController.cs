using RocketLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Windows;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PlayerRegistration(PlayerRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                MessageBox.Show("You have successfully registered your account");
                return RedirectToAction("Liquipedia", "Home");
            }
            return View();
        }
    }
}