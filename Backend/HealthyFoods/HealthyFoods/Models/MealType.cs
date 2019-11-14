using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Models
{
    public class MealType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        

        public int MainIngredientId { get; set; }
        public MainIngredient MainIngredient { get; set; }

        public MealType()
        {
        }


        public MealType(int id, string type)
        {
            Id = id;
            Type = type;

        }
    }
}
