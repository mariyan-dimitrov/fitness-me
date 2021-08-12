using FitnessDiary_17118074.Data;
using FitnessDiary_17118074.Models;
using FitnessDiary_17118074.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FitnessDiary_17118074.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/meal")]
    public class MealController : Controller
    {
        private readonly FitnessDiaryDbContext db;

        public MealController(FitnessDiaryDbContext _db)
        {
            db = _db;
        }

        [HttpPost]
        public IActionResult CreateMeal(MealVM model)
        {
            var user = GetUser();

            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }
            Meal meal = new Meal();
            meal.UserId = user;
            meal.FoodId = model.Meal.FoodId;
            meal.Date = model.Meal.Date;
            meal.Portion = model.Meal.Portion;
            meal.Type = model.Meal.Type;
            meal.CreatedAt_17118074 = DateTime.UtcNow;
            meal.UpdatedAt_17118074 = DateTime.UtcNow;

            db.Meal.Add(meal);
            db.SaveChanges();

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMeal(int id)
        {
            MealVM mealVM = new MealVM();

            mealVM.Meal = db.Meal.Find(id);
            mealVM.Foods = db.Food.ToList();

            if (mealVM.Meal == null)
            {
                return NotFound();
            }
            return Ok(mealVM);
        }

        [HttpPut]
        public IActionResult UpdateMeal(MealVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = GetUser();
           
            Meal meal = db.Meal.Find(model.Meal.Id);

            meal.UserId = user;
            meal.FoodId = model.Meal.FoodId;
            meal.Date = model.Meal.Date;
            meal.Portion = model.Meal.Portion;
            meal.Type = model.Meal.Type;
            meal.UpdatedAt_17118074 = DateTime.UtcNow;

            db.Meal.Update(meal);
            db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteMeal(int id)
        {
            var meal = db.Meal.Find(id);

            if (meal == null)
            {
                return NotFound();
            }
            db.Meal.Remove(meal);
            db.SaveChanges();
            return Ok();
        }

        private string GetUser()
        {
            var userName = User.Identity.Name;
            var userId = from u in db.Users
                where u.UserName == userName
                select u.Id;
            string user = (userId.FirstOrDefault() ?? "");

            return user;
        }
    }
}
