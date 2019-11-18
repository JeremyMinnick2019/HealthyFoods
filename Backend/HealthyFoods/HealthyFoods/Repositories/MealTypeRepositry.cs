using HealthyFoods.Data;
using HealthyFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFoods.Repositories
{
    public class MealTypeRepository : Repository<MealType>, IRepository<MealType>
    {
        public MealTypeRepository(dbContext context) : base(context)
        {

        }
    }
}