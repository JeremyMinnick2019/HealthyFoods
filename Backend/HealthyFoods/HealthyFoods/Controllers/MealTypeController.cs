using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFoods.Models;
using HealthyFoods.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFoods.Controllers
{
    [Route("api/MealType")]
    [ApiController]
    public class MealTypeController : ControllerBase
    {
        private IRepository<MealType> mealtypeRepo;

        public MealTypeController(IRepository<MealType> mealtypeRepo)
        {
            this.mealtypeRepo = mealtypeRepo;
        }

        [HttpGet]
        public IEnumerable<MealType> Get()
        {
            return mealtypeRepo.GetAll();
        }

        [HttpGet("{id}")]
        public MealType Get(int id)
        {
            return mealtypeRepo.GetById(id);
        }

        [HttpPost]
        public IEnumerable<MealType> Post([FromBody] MealType mealtype)
        {
            mealtypeRepo.Create(mealtype);
            return mealtypeRepo.GetAll();

        }

        [HttpPut("{id}")]
        public IEnumerable<MealType> Put([FromBody] MealType mealtype)
        {
            mealtypeRepo.Update(mealtype);
            return mealtypeRepo.GetAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<MealType> Delete(int id)
        {
            var deleteAlbum = mealtypeRepo.GetById(id);
            mealtypeRepo.Delete(deleteAlbum);
            return mealtypeRepo.GetAll();
        }
    }
}