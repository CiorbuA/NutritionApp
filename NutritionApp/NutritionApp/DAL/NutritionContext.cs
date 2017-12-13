using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace NutritionApp.DAL
{
    public class NutritionContext : DbContext
    {
        public NutritionContext() : base("NutritionContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Food> Food { get; set; }                   
        public DbSet<Consumption> Consumption { get; set; }
        public DbSet<Product> WareHouse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
