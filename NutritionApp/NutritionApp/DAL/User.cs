using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutritionApp.DAL
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public int Age { get; set; }

        public double ActivityLevel { get; set; }

        public Gender Gender { get; set; }

        public double RMB { get; set; }

        public ICollection<Consumption> Consumptions { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}