﻿using HealthyFoods.Data;
using HealthyFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Repositories
{
    public class MainIngredientRepository : Repository<MainIngredient>, IRepository<MainIngredient>
    {
        public MainIngredientRepository(dbContext context) : base(context)
        {

        }
    }
}