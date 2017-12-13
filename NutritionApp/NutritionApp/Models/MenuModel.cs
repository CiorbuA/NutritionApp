using NutritionApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NutritionApp.Models
{
    public class MenuModel
    {
   
        public List<Product> Menu { get; set; }

        public int TotalValue;
        public int TotalWeight;

    }

    public class ItemCollection
    {

        public Dictionary<int, int> Contents = new Dictionary<int, int>();
        public int TotalValue;
        public int TotalWeight;

        public void AddItem(Product item, int quantity)
        {
            if (Contents.ContainsKey(item.Id)) Contents[item.Id] += quantity; else Contents[item.Id] = quantity;
            TotalValue += quantity * item.Quantity;
            TotalWeight += quantity * item.Weight;
        }

        public ItemCollection Copy()
        {
            var ic = new ItemCollection();
            ic.Contents = new Dictionary<int, int>(this.Contents);
            ic.TotalValue = this.TotalValue;
            ic.TotalWeight = this.TotalWeight;
            return ic;
        }

    }
}
