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
            ViewBag.Message = "Products";

            return View();
        }

        public ActionResult Calendar()
        {
            ViewBag.Message = "Calendar";

            return View();
        }

        public ActionResult Suggestions()
        {
            ViewBag.Message = "Informations";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";
            return View();
        }

    }
}