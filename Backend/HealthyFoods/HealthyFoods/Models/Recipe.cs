using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Ingredient { get; set; }

        //public virtual ICollection<Albums> Albums { get; set; }

        public MainIngredient()
        {
        }


        public MainIngredient(int id, string ingredient)
        {
            ID = id;
            Ingredient = ingredient;

        }
    }
}
