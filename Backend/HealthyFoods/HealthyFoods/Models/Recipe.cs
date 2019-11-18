using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Calorie { get; set; }
        public string Instructions { get; set; }
        public string Image { get; set; }

        public Recipe()
        {
        }

        public Recipe(int id, string title, string calorie, string instructions)

        {
            Id = id;
            Title = title;
            Calorie = calorie;
            Instructions = instructions;

        }
    }
}
