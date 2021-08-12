using FitnessDiary_17118074.Data;
using FitnessDiary_17118074.Models.ViewModels;
using FitnessDiary_17118074.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FitnessDiary_17118074.Controllers
{
    [ApiController]
    [Route("api/food")]
    public class FoodController : Controller
    {
        private readonly FitnessDiaryDbContext db;

        public FoodController(FitnessDiaryDbContext _db)
        {
            db = _db;
        }

        //[Authorize]
        [HttpPost]
        public IActionResult CreateFood(NutritionVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Food food = new Food();
            food.Name = model.Food.Name;
            food.CreatedAt_17118074 = DateTime.UtcNow;
            food.UpdatedAt_17118074 = DateTime.UtcNow;

            Nutrition nutrition = new Nutrition();

            nutrition.Protein = model.Nutrition.Protein;
            int protein = Int32.Parse(nutrition.Protein);
            nutrition.Carbohydrates = model.Nutrition.Carbohydrates;
            int carbs = Int32.Parse(nutrition.Carbohydrates);
            nutrition.Fats = model.Nutrition.Fats;
            int fats = Int32.Parse(nutrition.Fats);

            food.Calories = (protein * 4) + (carbs * 4) + (fats * 9);
            db.Food.Add(food);
            db.SaveChanges();

            int latestFoodId = food.Id;
            nutrition.FoodId = latestFoodId;
            nutrition.CreatedAt_17118074 = DateTime.UtcNow;
            nutrition.UpdatedAt_17118074 = DateTime.UtcNow;

            db.Nutrition.Add(nutrition);
            db.SaveChanges();

            return Ok();
        }

        //[Authorize(Roles = "Administrator, User")]
        [HttpGet("{id}")]
        public IActionResult GetFood(int id)
        {
            NutritionVM nutritionVM = new NutritionVM();

            nutritionVM.Food = db.Food.Find(id);
            nutritionVM.Nutrition = db.Nutrition.FirstOrDefault(u => u.FoodId == nutritionVM.Food.Id);
            if (nutritionVM.Food == null)
            {
                return NotFound();
            }
            return Ok(nutritionVM);
        }

        //[Authorize(Roles = "Administrator, User")]
        [HttpPut]
        public IActionResult UpdateFood(NutritionVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Food food = db.Food.Find(model.Food.Id);
            food.Name = model.Food.Name;
            food.UpdatedAt_17118074 = DateTime.UtcNow;

            Nutrition nutrition = db.Nutrition.FirstOrDefault(u => u.FoodId == model.Food.Id);

            nutrition.Protein = model.Nutrition.Protein;
            int protein = Int32.Parse(nutrition.Protein);
            nutrition.Carbohydrates = model.Nutrition.Carbohydrates;
            int carbs = Int32.Parse(nutrition.Carbohydrates);
            nutrition.Fats = model.Nutrition.Fats;
            int fats = Int32.Parse(nutrition.Fats);

            food.Calories = (protein * 4) + (carbs * 4) + (fats * 9);
            db.Food.Update(food);
            db.SaveChanges();

            int latestFoodId = food.Id;
            nutrition.FoodId = latestFoodId;
            nutrition.UpdatedAt_17118074 = DateTime.UtcNow;

            db.Nutrition.Update(nutrition);
            db.SaveChanges();
            return Ok();
        }

        // [Authorize("Administrator")]
        [HttpDelete]
        public IActionResult DeleteFood(int? id)
        {
            var food = db.Food.Find(id);
            var nutrition = db.Nutrition.FirstOrDefault(u => u.FoodId == food.Id);
            if (food == null)
            {
                return NotFound();
            }
            db.Nutrition.Remove(nutrition);
            db.Food.Remove(food);
            db.SaveChanges();

            return Ok();
        }
    }
}
