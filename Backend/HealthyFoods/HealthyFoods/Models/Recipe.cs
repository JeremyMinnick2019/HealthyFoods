﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Calorie { get; set; }
        public string Instructions { get; set; }


        //public virtual ICollection<Albums> Albums { get; set; }

        public Recipe()
        {
        }


<<<<<<< Updated upstream
        public Recipe(int id, string ingredient)
=======
        public Recipe(int id, string title, string calorie , string instructions )
>>>>>>> Stashed changes
        {
            ID = id;
            Title = title;
            Calorie = calorie;
            Instructions = instructions;

        }
    }
}