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
    public class MainIngredientControllerTest
    {
        private MainIngredientController underTest;
        IRepository<MainIngredient> mainingredientRepo;

        public MainIngredientControllerTest()
        {
            mainingredientRepo = Substitute.For<IRepository<MainIngredient>>();
            underTest = new MainIngredientController(mainingredientRepo);
        }

        [Fact]
        public void Get_Returns_List_Of_MainIngredient()
        {
            var expectedMainIngredient = new List<MainIngredient>()
            {
                new MainIngredient(1, "Cheese", "/Images/cheese.jpg"),
                new MainIngredient(2, "Chicken", "/Images/chicken.jpg")
            };

            mainingredientRepo.GetAll().Returns(expectedMainIngredient);

            var result = underTest.Get();

            Assert.Equal(expectedMainIngredient, result.ToList());

        }

        [Fact]
        public void Post_Creates_New_MainIngredient()
        {
            var newMainIngredient = new MainIngredient(1, "New MainIngredient", "new img");
            var mainingredientList = new List<MainIngredient>();

            mainingredientRepo.When(t => t.Create(newMainIngredient))
                .Do(t => mainingredientList.Add(newMainIngredient));

            mainingredientRepo.GetAll().Returns(mainingredientList);

            var result = underTest.Post(newMainIngredient);

            Assert.Contains(newMainIngredient, result);
        }

        [Fact]
        public void Delete_Removes_An_MainIngredient()
        {
            var mainingredientId = 1;
            var deletedMainIngredient = new MainIngredient(mainingredientId, "MainIngredient1", "Img");
            var mainingredientList = new List<MainIngredient>()
            {
                deletedMainIngredient,
                new MainIngredient (2, "MainIngredient2", "img2")
            };

            mainingredientRepo.GetById(mainingredientId).Returns(deletedMainIngredient);
            mainingredientRepo.When(d => d.Delete(deletedMainIngredient))
                .Do(d => mainingredientList.Remove(deletedMainIngredient));
            mainingredientRepo.GetAll().Returns(mainingredientList);

            var result = underTest.Delete(mainingredientId);

            Assert.All(result, item => Assert.Contains("MainIngredient2", item.Image));
        }

        [Fact]
        public void Put_Updates_An_MainIngredient()
        {
            var originalMainIngredient = new MainIngredient(1, "MainIngredient", "img");
            var expectedMainIngredient = new List<MainIngredient>()
            {
                originalMainIngredient
            };

            var updatedMainIngredient = new MainIngredient(1, "Updated MainIngredient", "Updated img");

            mainingredientRepo.When(t => mainingredientRepo.Update(updatedMainIngredient))
                .Do(Callback.First(t => expectedMainIngredient.Remove(originalMainIngredient))
                .Then(t => expectedMainIngredient.Add(updatedMainIngredient)));
            mainingredientRepo.GetAll().Returns(expectedMainIngredient);

            var result = underTest.Put(updatedMainIngredient);

            Assert.All(result, item => Assert.Contains("Updated MainIngredient", item.Image));
        }
    }
}
