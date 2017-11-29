using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutritionApp.DAL
{
    public class NutritionInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NutritionContext>
    {
        protected override void Seed(NutritionContext context)
        {
            var food = new List<Food>
            {
                new Food { Category = FoodCategory.Fruit, Name = "Banana", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Fruit, Name = "Apple", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Fruit, Name = "Orange", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Vegetable, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Vegetable, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Vegetable, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Meat, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Meat, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Meat, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Fish, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Fish, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Fish, Name = "", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
            };

            food.ForEach(s => context.Food.Add(s));
            context.SaveChanges();
        }
    }
}