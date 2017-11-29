using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutritionApp.DAL
{
	public class Consumption
	{
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime Date { get; set; }

        public string FoodId { get; set; }

        public double Quantity { get; set; }

        public virtual ICollection<User> User { get; set; }

        public virtual ICollection<Food> Food { get; set; }

    }
}