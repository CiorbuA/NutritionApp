using NutritionApp.DAL;
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

        public ActionResult Food()
        {
            var food = new List<Food>();
            using (var context = new NutritionContext())
            {
                food = context.Food.ToList();
            }

            var model = new FoodModel()
            {
                FoodList = food
            };
            return View(model);
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

        public ActionResult CaldulateRMB(RMBModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("About", model);
            }

            var user = new User()
            {
                Name = model.Name,
                Weight = model.Weight,
                Height = model.Height,
                Age = model.Age,
                Gender = model.Gender,
                ActivityLevel = 10
            };

            using (var context = new NutritionContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }

            return RedirectToAction("Index");

        }

    }
}