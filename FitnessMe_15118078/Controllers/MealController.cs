using FitnessMe_15118078.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using FitnessMe_15118078.Data.Models;
using FitnessMe_15118078.Models.ViewModels;

namespace FitnessMe_15118078.Controllers
{
    [Route("api/meal")]
    public class MealController : BaseAuthorizeController
    {
        private readonly FitnessMeDbContext _dbContext;

        public MealController(FitnessMeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult CreateMeal(CreateMealViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }
            
            var meal = new Meal
            {
                UserId = GetUserId(),
                FoodId = model.FoodId,
                Date = model.Date,
                Portion = model.Portion,
                CreatedAt_15118078 = DateTime.UtcNow,
                UpdatedAt_15118078 = DateTime.UtcNow
            };

            _dbContext.Meal.Add(meal);
            _dbContext.SaveChanges();

            return Ok(meal.Id);
        }

        [HttpGet]
        public IActionResult GetMeals(int pageNumber, int pageSize)
        {
            var meals = _dbContext.Meal.Where(m => m.UserId == GetUserId())
                                       .Skip(pageNumber * pageSize)
                                       .Take(pageSize)
                                       .Select(m => new DisplayMealViewModel()
                                       {
                                           Id = m.Id,
                                           Date = m.Date,
                                           FoodId = m.FoodId,
                                           Portion = m.Portion
                                       })
                                       .ToArray();

            return Ok(meals);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMeal(int id, CreateMealViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Meal meal = _dbContext.Meal.Find(id);
            if (meal is null)
            {
                return BadRequest();
            }

            meal.UserId = GetUserId();
            meal.FoodId = model.FoodId;
            meal.Date = model.Date;
            meal.Portion = model.Portion;
            meal.UpdatedAt_15118078 = DateTime.UtcNow;

            _dbContext.Meal.Update(meal);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMeal(int id)
        {
            var meal = _dbContext.Meal.Find(id);
            if (meal == null)
            {
                return NotFound();
            }

            _dbContext.Meal.Remove(meal);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
