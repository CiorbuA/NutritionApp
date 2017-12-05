using System;
using System.Collections.Generic;
using System.Linq;
using NutritionApp.DAL;
using System.Web;

namespace NutritionApp.Models
{
    public class ConsumptionModel
    {
        public List<Consumption> ConsumtionList  { get; set; }

        public double KCal { get; set; }

    }
}