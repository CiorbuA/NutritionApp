using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutritionApp.DAL
{
    public class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public FoodCategory Category { get; set; }

        public double Fats { get; set; }

        public double KCal { get; set; }

        public double Proteines { get; set; }

        public double Carbohydrates { get; set; }
    }

    public enum FoodCategory
    {
        Drink = 1,
        Meat = 2,
        Fruit = 3,
        Vegetable = 4,
        Fish = 5,
        Seed = 6
    }
}