using HealthyFoods.Controllers;
using System;
using Xunit;
using System.Linq;
using HealthyFoods.Data;
using HealthyFoods.Repositories;
using NSubstitute;
using HealthyFoods.Models;
using System.Collections.Generic;

namespace HealthyFood.Tests
{
    public class RecipeControllerTest
    {
        private RecipeController underTest;
        IRepository<Recipe> recipeRepo;

        public RecipeControllerTest()
        {
            recipeRepo = Substitute.For<IRepository<Recipe>>();
            underTest = new RecipeController(recipeRepo);
        }

        [Fact]
        public void Get_Returns_List_Of_Recipes()
        {
            var expectedRecipes = new List<Recipe>()
            {
                new Recipe(1, "Chocolate Bar", "410", "Homemade Chocolate Bars"),
                new Recipe(2, "Biscuits", "310", "Preheat oven to 450 degrees")
            };

            recipeRepo.GetAll().Returns(expectedRecipes);

            var result = underTest.Get();

            Assert.Equal(expectedRecipes, result.ToList());

        }

        [Fact]
        public void Post_Creates_New_Recipes()
        {
            var newRecipe = new Recipe(1, "New title", "New calorie", "New instructions");
            var recipeList = new List<Recipe>();

            recipeRepo.When(t => t.Create(newRecipe))
                .Do(t => recipeList.Add(newRecipe));

            recipeRepo.GetAll().Returns(recipeList);

            var result = underTest.Post(newRecipe);

            Assert.Contains(newRecipe, result);
        }

        [Fact]
        public void Delete_Removes_An_Recipe()
        {
            var recipeId = 1;
            var deletedRecipe = new Recipe(recipeId, "First Title", "First calorie", "first instruction");
            var recipeList = new List<Recipe>()
            {
                deletedRecipe,
                new Recipe (2, "Second Title", "Second calorie", "Second instruction")
            };

            recipeRepo.GetById(recipeId).Returns(deletedRecipe);
            recipeRepo.When(d => d.Delete(deletedRecipe))
                .Do(d => recipeList.Remove(deletedRecipe));
            recipeRepo.GetAll().Returns(recipeList);

            var result = underTest.Delete(recipeId);

            Assert.All(result, item => Assert.Contains("Second Recipe", item.Title));
        }

        [Fact]
        public void Put_Updates_An_Recipe()
        {
            var originalRecipe = new Recipe(1, "First Title", "First calorie", "first instruction");
            var expectedRecipe = new List<Recipe>()
            {
                originalRecipe
            };

            var updatedRecipe = new Recipe(1, "Updated Title", "Updated calorie", "Updated instruction");

            recipeRepo.When(t => recipeRepo.Update(updatedRecipe))
                .Do(Callback.First(t => expectedRecipe.Remove(originalRecipe))
                .Then(t => expectedRecipe.Add(updatedRecipe)));
            recipeRepo.GetAll().Returns(expectedRecipe);

            var result = underTest.Put(updatedRecipe);

            Assert.All(result, item => Assert.Contains("Updated Recipe", item.Title));
        }
    }
}
