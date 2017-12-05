using NutritionApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutritionApp.Models
{
    public class AboutModel
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public double Activity { get; set; }

        public User User { get; set; }
    }
}