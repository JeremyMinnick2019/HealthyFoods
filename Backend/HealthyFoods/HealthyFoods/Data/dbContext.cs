using HealthyFoods.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Data
{
        public class dbContext : DbContext
        {
            public DbSet<Recipe> Recipes { get; set; }
            public DbSet<MealType> MealTypes { get; set; }
            public DbSet<MainIngredient> MainIngredients { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var connectionString = "Server=(localdb)\\mssqllocaldb;Database=HealthlyFoodsDB;Trusted_Connection=True;";

                optionsBuilder.UseSqlServer(connectionString);
                //.UseLazyLoadingProxies();

                base.OnConfiguring(optionsBuilder);
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }
    
}
