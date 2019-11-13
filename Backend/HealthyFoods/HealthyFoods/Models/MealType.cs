﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Models
{
    public class MealType
    {
        public int ID { get; set; }
        public string Type { get; set; }
        


        //public virtual ICollection<Albums> Albums { get; set; }

        public MealType()
        {
        }


        public MealType(int id, string type)
        {
            ID = id;
            Type = type;

        }
    }
}