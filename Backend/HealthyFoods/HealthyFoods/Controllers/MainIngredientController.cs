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
    [Route("api/[controller]")]
    [ApiController]
    public class MainIngredientController : ControllerBase
    {
        private IRepository<MainIngredient> mainingredientRepo;

        public MainIngredientController(IRepository<MainIngredient> mainingredientRepo)
        {
            this.mainingredientRepo = mainingredientRepo;
        }

        // GET api/Albums
        [HttpGet]
        public IEnumerable<MainIngredient> Get()
        {
            return mainingredientRepo.GetAll();
        }

        // GET api/Albums/5
        [HttpGet("{id}")]
        public MainIngredient Get(int id)
        {
            return mainingredientRepo.GetById(id);
        }

        // POST api/Albums
        [HttpPost]
        public IEnumerable<MainIngredient> Post([FromBody] MainIngredient mainingredient)
        {
            mainingredientRepo.Create(mainingredient);
            return mainingredientRepo.GetAll();

        }

        // PUT api/Albums/5
        [HttpPut("{id}")]
        public IEnumerable<MainIngredient> Put([FromBody] MainIngredient mainingredient)
        {
            mainingredientRepo.Update(mainingredient);
            return mainingredientRepo.GetAll();
        }

        // DELETE api/Albums/5
        [HttpDelete("{id}")]
        public IEnumerable<MainIngredient> Delete(int id)
        {
            var deleteAlbum = mainingredientRepo.GetById(id);
            mainingredientRepo.Delete(deleteAlbum);
            return mainingredientRepo.GetAll();
        }
    }
}