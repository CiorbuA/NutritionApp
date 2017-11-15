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

        public ActionResult List()
        {
            var nutrition = new List<Nutrition>();
            using (NutritionEntities dc = new NutritionEntities())
            {
                nutrition = dc.Nutritions.ToList();
            }
            return View(nutrition);
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

    }
}