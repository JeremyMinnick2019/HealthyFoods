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
    [Route("api/Recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private IRepository<Recipe> recipeRepo;

        public RecipeController(IRepository<Recipe> recipeRepo)
        {
            this.recipeRepo = recipeRepo;
        }

        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return recipeRepo.GetAll();
        }

        [HttpGet("{id}")]
        public Recipe Get(int id)
        {
            return recipeRepo.GetById(id);
        }

        [HttpPost]
        public IEnumerable<Recipe> Post([FromBody] Recipe recipe)
        {
            recipeRepo.Create(recipe);
            return recipeRepo.GetAll();

        }

        [HttpPut("{id}")]
        public IEnumerable<Recipe> Put([FromBody] Recipe recipe)
        {
            recipeRepo.Update(recipe);
            return recipeRepo.GetAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Recipe> Delete(int id)
        {
            var deleteAlbum = recipeRepo.GetById(id);
            recipeRepo.Delete(deleteAlbum);
            return recipeRepo.GetAll();
        }
    }
}