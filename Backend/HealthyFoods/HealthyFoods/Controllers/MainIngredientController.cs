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
    [Route("api/MainIngredient")]
    [ApiController]
    public class MainIngredientController : ControllerBase
    {
        private IRepository<MainIngredient> mainingredientRepo;

        public MainIngredientController(IRepository<MainIngredient> mainingredientRepo)
        {
            this.mainingredientRepo = mainingredientRepo;
        }

        [HttpGet]
        public IEnumerable<MainIngredient> Get()
        {
            return mainingredientRepo.GetAll();
        }

        [HttpGet("{id}")]
        public MainIngredient Get(int id)
        {
            return mainingredientRepo.GetById(id);
        }

        [HttpPost]
        public IEnumerable<MainIngredient> Post([FromBody] MainIngredient mainingredient)
        {
            mainingredientRepo.Create(mainingredient);
            return mainingredientRepo.GetAll();

        }

        [HttpPut("{id}")]
        public IEnumerable<MainIngredient> Put([FromBody] MainIngredient mainingredient)
        {
            mainingredientRepo.Update(mainingredient);
            return mainingredientRepo.GetAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<MainIngredient> Delete(int id)
        {
            var deleteAlbum = mainingredientRepo.GetById(id);
            mainingredientRepo.Delete(deleteAlbum);
            return mainingredientRepo.GetAll();
        }
    }
}