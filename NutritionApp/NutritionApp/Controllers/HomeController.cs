using NutritionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Categories";

            return View();
        }

        public ActionResult Calendar()
        {
            ViewBag.Message = "Calendar";

            return View();
        }

        public ActionResult Suggestions()
        {
            ViewBag.Message = "Details";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";
            return View();
        }

        public ActionResult CaldulateRMB(RMB model)
        {

            //using(var db = NutritionCtx())
            //{
            //    db.User.Add(new User() {
            //        Name = model.Name
            //    })
            //    db.SaveChanges();
            //}

            return View("Home");

        }

    }
}