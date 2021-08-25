using FitnessMe_15118078.Data;
using FitnessMe_15118078.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using FitnessMe_15118078.Common;
using FitnessMe_15118078.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace FitnessMe_15118078.Controllers
{
    [Route("api/food")]
    public class FoodController : BaseAuthorizeController
    {
        private readonly FitnessMeDbContext _dbContext;

        public FoodController(FitnessMeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult CreateFood(CreateFoodViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var food = new Food
            {
                Name = model.Name,
                Protein = model.Protein,
                Carbs = model.Carbs,
                Fats = model.Fats,
                Calories = (model.Protein * 4) + (model.Carbs * 4) + (model.Fats * 9),
                CreatedAt_15118078 = DateTime.UtcNow,
                UpdatedAt_15118078 = DateTime.UtcNow
            };

            _dbContext.Food.Add(food);
            _dbContext.SaveChanges();

            return Ok(food.Id);
        }

        [HttpGet]
        public IActionResult GetFood()
        {
            var foods = _dbContext.Food.Select(f => new DisplayFoodViewModel
                                                {
                                                    Id = f.Id,
                                                    Name = f.Name,
                                                    Fats = f.Fats,
                                                    Carbs = f.Carbs,
                                                    Protein = f.Protein,
                                                })
                                        .ToArray();

            return Ok(foods);
        }

        [Authorize(Roles = Constants.Roles.Administrator)]
        [HttpPut("{id}")]
        public IActionResult UpdateFood(int id, CreateFoodViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Food food = _dbContext.Food.Find(id);
            if (food is null)
            {
                return NotFound();
            }

            food.Name = model.Name;
            food.Protein = model.Protein;
            food.Carbs = model.Carbs;
            food.Fats = model.Fats;
            food.Calories = (model.Protein * 4) + (model.Carbs * 4) + (model.Fats * 9);
            food.UpdatedAt_15118078 = DateTime.UtcNow;

            _dbContext.Food.Update(food);
            _dbContext.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = Constants.Roles.Administrator)]
        [HttpDelete("{id}")]
        public IActionResult DeleteFood(int id)
        {
            Food food = _dbContext.Food.Find(id);
            if (food == null)
            {
                return NotFound();
            }
            
            _dbContext.Food.Remove(food);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
