using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NutritionApp.DAL
{
    public class Product
    {
        public int Id { get; set; }

        public int FoodId { get; set; }

        public int Quantity { get; set; }

        public int Weight { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }

    }

   
}