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
            var user = new User();
            using (var context = new NutritionContext())
            {
                user = context.Users.FirstOrDefault();
            }

            var model = new AboutModel()
            {
                User = user
            };

            return View("About", model);
        }

        private double GetRMB(AboutModel model)
        {
            //Femei: 655 + (9,6 x greutatea) + (1,8 x inaltimea) – (4,7 x varsta)
            if (model.Gender == Gender.Female)
            {
                return 655 + 9.6 * model.Weight + 1.8 * model.Height - 4.7 * model.Age;
            }
            else
            {
                //Barbati: 66 + (13,7 x greutatea) + (5 x inaltimea) – (6,8 x varsta)
                return 66 + 13.7 * model.Weight + 5 * model.Height - 6.8 * model.Age;
            }
        }

        public ActionResult Consumption() {
            var consumptions = new List<Consumption>();
            var date = DateTime.Now.Date;
            using (var context = new NutritionContext())
            {               
                consumptions = context.Consumption.Include("Food").Where(w => w.Date > date).ToList();
                
            }

            var kcal = consumptions.Sum(s => s.Food.KCal * s.Quantity);
            var prot = consumptions.Sum(p => p.Food.Proteines * p.Quantity);
            var carb = consumptions.Sum(c => c.Food.Carbohydrates * c.Quantity);
            



            var user = consumptions.FirstOrDefault()?.User;

            var model = new ConsumptionModel()
            {
                ConsumtionList = consumptions,
                KCal = user?.RMB ?? 2000 - kcal
                
            };
            return View(model);
    }

        public ActionResult CaldulateRMB(AboutModel model)
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
                ActivityLevel = model.Activity,
                RMB = GetRMB(model)
                         
            };

            using (var context = new NutritionContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }

            return About();

        }

        public bool SaveConsumtion(int foodId, double quantity)
        {
            var consumtion = new Consumption()
            {
                FoodId = foodId,
                Date = DateTime.Now,
                Quantity = quantity,
                UserId = 1
            };

            try
            {
                using (var context = new NutritionContext())
                {
                    context.Consumption.Add(consumtion);
                    context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                // Something is going wrong
                return false;
            }
            
            return true;
        }

    }
}