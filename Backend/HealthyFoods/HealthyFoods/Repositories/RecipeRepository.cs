using HealthyFoods.Data;
using HealthyFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Repositories
{
    public class RecipeRepository : Repository<Recipe>, IRepository<Recipe>
    {
        public RecipeRepository(dbContext context) : base(context)
        {

        }
    }
}