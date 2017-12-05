using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NutritionApp.DAL
{
	public class Consumption
	{
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime Date { get; set; }

        public int FoodId { get; set; }

        public double Quantity { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }

    }
}