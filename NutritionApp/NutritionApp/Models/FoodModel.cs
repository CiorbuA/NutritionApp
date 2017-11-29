using NutritionApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutritionApp.Models
{
    public class FoodModel
    {
        public string Search { get; set; }

        public FoodCategory Category { get; set; }

        public List<Food> FoodList { get; set; }

    }
}