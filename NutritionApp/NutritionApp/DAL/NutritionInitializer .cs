using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace NutritionApp.DAL
{
    public class NutritionInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NutritionContext>
    {
        protected override void Seed(NutritionContext context)
        {
            var food = new List<Food>
            {
                new Food { Category = FoodCategory.Drink, Name = "Water", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Drink, Name = "Juice", Carbohydrates = 8, Fats = 0, KCal = 2, Proteines = 2 },
                new Food { Category = FoodCategory.Drink, Name = "Tea", Carbohydrates = 4, Fats = 0, KCal = 1, Proteines = 2 },
                new Food { Category = FoodCategory.Drink, Name = "Coffe", Carbohydrates = 5, Fats = 0, KCal = 2, Proteines = 4 },
                new Food { Category = FoodCategory.Drink, Name = "Cappucino", Carbohydrates = 7, Fats = 0, KCal = 5, Proteines = 10 },
                new Food { Category = FoodCategory.Drink, Name = "Beer", Carbohydrates = 7, Fats = 0, KCal = 7, Proteines = 15 },
                new Food { Category = FoodCategory.Drink, Name = "Champagne", Carbohydrates = 6, Fats = 0, KCal = 5, Proteines = 8},
                new Food { Category = FoodCategory.Drink, Name = "Wine", Carbohydrates = 8, Fats = 0, KCal = 9, Proteines = 22 },
                new Food { Category = FoodCategory.Drink, Name = "Energizant", Carbohydrates = 15, Fats = 0, KCal = 20, Proteines = 50 },
                new Food { Category = FoodCategory.Drink, Name = "Brandy", Carbohydrates = 0, Fats = 0, KCal = 0, Proteines = 56 },


                new Food { Category = FoodCategory.Meat, Name = "Pork", Carbohydrates = 56, Fats = 98, KCal = 58, Proteines = 59 },
                new Food { Category = FoodCategory.Meat, Name = "Chicken", Carbohydrates = 45, Fats = 54, KCal = 25, Proteines = 49 },
                new Food { Category = FoodCategory.Meat, Name = "Rabbit", Carbohydrates = 21, Fats = 23, KCal = 45, Proteines = 65 },
                new Food { Category = FoodCategory.Meat, Name = "Beef", Carbohydrates = 89, Fats = 87, KCal = 52, Proteines = 54 },
                new Food { Category = FoodCategory.Meat, Name = "Goose", Carbohydrates = 50, Fats = 60, KCal = 25, Proteines = 97},
                new Food { Category = FoodCategory.Meat, Name = "Pheasant", Carbohydrates = 52, Fats = 23, KCal = 40, Proteines = 20 },
                new Food { Category = FoodCategory.Meat, Name = "Liver (Chicken)", Carbohydrates = 22, Fats = 20, KCal = 30, Proteines = 12 },
                new Food { Category = FoodCategory.Meat, Name = "Heart (Chicken)", Carbohydrates = 25, Fats = 36, KCal = 20, Proteines = 20 },
                new Food { Category = FoodCategory.Meat, Name = "Chest (Chicken)", Carbohydrates = 14, Fats = 10, KCal = 40, Proteines = 33 },
                new Food { Category = FoodCategory.Meat, Name = "Pulp (Chicken)", Carbohydrates =  45, Fats = 25, KCal = 45, Proteines = 99 },
                new Food { Category = FoodCategory.Meat, Name = "Sausage",Carbohydrates = 42, Fats = 26, KCal = 38, Proteines = 79 },
                new Food { Category = FoodCategory.Meat, Name = "Ham ", Carbohydrates = 89, Fats = 25, KCal = 47, Proteines = 50 },

                new Food { Category = FoodCategory.Fruit, Name = "Banana", Carbohydrates = 10, Fats = 5, KCal = 55, Proteines = 25 },
                new Food { Category = FoodCategory.Fruit, Name = "Apple", Carbohydrates = 3, Fats = 8, KCal = 56, Proteines = 41 },
                new Food { Category = FoodCategory.Fruit, Name = "Orange", Carbohydrates = 12, Fats = 11, KCal = 80, Proteines = 30 },
                new Food { Category = FoodCategory.Fruit, Name = "Kiwi", Carbohydrates = 14, Fats = 10, KCal = 40, Proteines = 33 },
                new Food { Category = FoodCategory.Fruit, Name = "Plum", Carbohydrates = 13, Fats = 5, KCal = 45, Proteines = 24 },
                new Food { Category = FoodCategory.Fruit, Name = "Peach", Carbohydrates = 4, Fats = 18, KCal = 77, Proteines = 9 },
                new Food { Category = FoodCategory.Fruit, Name = "Strawberry", Carbohydrates = 7, Fats = 20, KCal = 52, Proteines = 37 },
                new Food { Category = FoodCategory.Fruit, Name = "Rasberry", Carbohydrates = 9, Fats = 27, KCal = 74, Proteines = 41 },
                new Food { Category = FoodCategory.Fruit, Name = "Watermelon", Carbohydrates = 4, Fats = 4, KCal = 48, Proteines = 0 },
                new Food { Category = FoodCategory.Fruit, Name = "Pear", Carbohydrates = 5, Fats = 26, KCal = 89, Proteines = 26},
                new Food { Category = FoodCategory.Fruit, Name = "Grape", Carbohydrates = 7, Fats = 38, KCal = 57, Proteines = 23 },
                new Food { Category = FoodCategory.Fruit, Name = "Pomegranate", Carbohydrates = 8, Fats = 19, KCal = 75, Proteines = 74 },

                new Food { Category = FoodCategory.Vegetable, Name = "Tomato", Carbohydrates = 2, Fats = 2, KCal = 10, Proteines = 15},
                new Food { Category = FoodCategory.Vegetable, Name = "Cucumber", Carbohydrates = 1, Fats = 0, KCal = 0, Proteines = 10 },
                new Food { Category = FoodCategory.Vegetable, Name = "Cabbage", Carbohydrates = 1, Fats = 0, KCal = 1, Proteines = 24 },
                new Food { Category = FoodCategory.Vegetable, Name = "Cauliflower", Carbohydrates = 2, Fats = 0, KCal = 0, Proteines = 55},
                new Food { Category = FoodCategory.Vegetable, Name = "Beans", Carbohydrates = 12, Fats = 20, KCal = 0, Proteines = 0 },
                new Food { Category = FoodCategory.Vegetable, Name = "Potato", Carbohydrates = 24, Fats = 15, KCal = 45, Proteines = 65 },
                new Food { Category = FoodCategory.Vegetable, Name = "Peppers", Carbohydrates = 0, Fats = 2, KCal = 5, Proteines = 25 },
                new Food { Category = FoodCategory.Vegetable, Name = "Carrot", Carbohydrates = 0, Fats = 5, KCal = 0, Proteines = 15},
                new Food { Category = FoodCategory.Vegetable, Name = "Pumpkin", Carbohydrates = 1, Fats = 7, KCal = 14, Proteines = 89 },
                new Food { Category = FoodCategory.Vegetable, Name = "Radish", Carbohydrates = 4, Fats = 0, KCal = 4, Proteines = 23 },
                new Food { Category = FoodCategory.Vegetable, Name = "Beet", Carbohydrates = 1, Fats = 8, KCal = 4, Proteines = 44 },
                new Food { Category = FoodCategory.Vegetable, Name = "Onion", Carbohydrates = 1, Fats = 0, KCal = 1, Proteines = 99 },

                new Food { Category = FoodCategory.Fish, Name = "Carp", Carbohydrates = 15, Fats = 5, KCal = 10, Proteines = 24},
                new Food { Category = FoodCategory.Fish, Name = "Mold Fish", Carbohydrates = 14, Fats = 8, KCal = 12, Proteines = 69},
                new Food { Category = FoodCategory.Fish, Name = "Crab", Carbohydrates = 36, Fats = 45, KCal = 55, Proteines = 78 },
                new Food { Category = FoodCategory.Fish, Name = "Trout", Carbohydrates = 45, Fats = 25, KCal = 45, Proteines = 99},
                new Food { Category = FoodCategory.Fish, Name = "Salmon", Carbohydrates = 35, Fats = 4, KCal = 52, Proteines = 87 },
                new Food { Category = FoodCategory.Fish, Name = "Tipple", Carbohydrates = 25, Fats = 35, KCal = 25, Proteines = 86},
                new Food { Category = FoodCategory.Fish, Name = "Caviar", Carbohydrates = 21, Fats = 15, KCal = 23, Proteines = 54 },
                new Food { Category = FoodCategory.Fish, Name = "Shells", Carbohydrates = 4, Fats = 26, KCal = 38, Proteines = 75 },

                new Food { Category = FoodCategory.Seed, Name = "Sesame", Carbohydrates = 85, Fats = 95, KCal = 10, Proteines = 24},
                new Food { Category = FoodCategory.Seed, Name = "Sunflower", Carbohydrates = 35, Fats = 89, KCal = 10, Proteines = 69},
                new Food { Category = FoodCategory.Seed, Name = "Peanuts", Carbohydrates = 65, Fats = 85, KCal = 40, Proteines = 75},
                new Food { Category = FoodCategory.Seed, Name = "Nuts", Carbohydrates = 47, Fats = 65, KCal = 20, Proteines = 94},
                new Food { Category = FoodCategory.Seed, Name = "Poppy", Carbohydrates = 15, Fats = 5, KCal = 10, Proteines = 24},

            };

            food.ForEach(s => context.Food.Add(s));
            context.SaveChanges();
        }
    }
}