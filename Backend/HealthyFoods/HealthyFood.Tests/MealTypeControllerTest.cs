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
    public class MealTypeControllerTest
    {
        private MealTypeController underTest;
        IRepository<MealType> mealtypeRepo;

        public MealTypeControllerTest()
        {
            mealtypeRepo = Substitute.For<IRepository<MealType>>();
            underTest = new MealTypeController(mealtypeRepo);
        }

        [Fact]
        public void Get_Returns_List_Of_MealTypes()
        {
            var expectedMealTypes = new List<MealType>()
            {
                new MealType(1, "Man on the Moon"),
                new MealType(2, "Man on the Moon 2")
            };

            mealtypeRepo.GetAll().Returns(expectedMealTypes);

            var result = underTest.Get();

            Assert.Equal(expectedMealTypes, result.ToList());

        }

        [Fact]
        public void Post_Creates_New_MealType()
        {
            var newMealType = new MealType(1, "New MealType");
            var mealtypeList = new List<MealType>();

            mealtypeRepo.When(t => t.Create(newMealType))
                .Do(t => mealtypeList.Add(newMealType));

            mealtypeRepo.GetAll().Returns(mealtypeList);

            var result = underTest.Post(newMealType);

            Assert.Contains(newMealType, result);
        }

        [Fact]
        public void Delete_Removes_An_MealType()
        {
            var mealtypeId = 1;
            var deletedMealType = new MealType(mealtypeId, "First MealType");
            var mealtypeList = new List<MealType>()
            {
                deletedMealType,
                new MealType (2, "Second MealType")
            };

            mealtypeRepo.GetById(mealtypeId).Returns(deletedMealType);
            mealtypeRepo.When(d => d.Delete(deletedMealType))
                .Do(d => mealtypeList.Remove(deletedMealType));
            mealtypeRepo.GetAll().Returns(mealtypeList);

            var result = underTest.Delete(mealtypeId);

            Assert.All(result, item => Assert.Contains("Second MealType", item.Type));
        }

        [Fact]
        public void Put_Updates_An_MealType()
        {
            var originalMealType = new MealType(1, "First MealType");
            var expectedMealType = new List<MealType>()
            {
                originalMealType
            };

            var updatedMealType = new MealType(1, "Updated MealType");

            mealtypeRepo.When(t => mealtypeRepo.Update(updatedMealType))
                .Do(Callback.First(t => expectedMealType.Remove(originalMealType))
                .Then(t => expectedMealType.Add(updatedMealType)));
            mealtypeRepo.GetAll().Returns(expectedMealType);

            var result = underTest.Put(updatedMealType);

            Assert.All(result, item => Assert.Contains("Updated Artist", item.Type));
        }
    }
}
