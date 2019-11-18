using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Models
{
    public class MainIngredient
    {
        public int Id { get; set; }
        public string Ingredient { get; set; }
        public string Image { get; set; }

        public MainIngredient()
        {
        }


        public MainIngredient(int id, string ingredient, string image)
        {
            Id = id;
            Ingredient = ingredient;
            

        }

    }
}