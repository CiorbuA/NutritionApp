using NutritionApp.DAL;
using NutritionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        // GET: Email
        public ActionResult Suggestions()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suggestions(string receiverEmail, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderemail = new MailAddress("nutrition161@gmail.com", "Nutrition");
                    var receiveremail = new MailAddress(receiverEmail, "Receiver");

                    var password = "anaviorica";
                    var sub = subject;
                    var body = message;

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderemail.Address, password)
                    };

                    using (var mess = new MailMessage(senderemail, receiveremail)
                    {
                        Subject = subject,
                        Body = body
                    }
                    )
                    {
                        smtp.Send(mess);
                    }
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "There are some problems in sending email";
            }
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