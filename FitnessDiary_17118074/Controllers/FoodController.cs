using FitnessDiary_17118074.Data;
using FitnessDiary_17118074.Models.ViewModels;
using FitnessDiary_17118074.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FitnessDiary_17118074.Controllers
{
    public class FoodController : Controller
    {
        private readonly FitnessDiaryDbContext db;

        public FoodController(FitnessDiaryDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            IEnumerable<Food> objectList = db.Food;


            return Ok(objectList);
        }

        [Authorize]
        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NutritionVM model)
        {
            if (ModelState.IsValid)
            {
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

                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET - EDIT
        [Authorize(Roles = "Administrator, User")]
        public IActionResult Edit(int? id)
        {
            NutritionVM nutritionVM = new NutritionVM();

            if (id == null)
            {
                return View(nutritionVM);
            }
            else
            {
                nutritionVM.Food = db.Food.Find(id);
                nutritionVM.Nutrition = db.Nutrition.FirstOrDefault(u => u.FoodId == nutritionVM.Food.Id);
                if (nutritionVM.Food == null)
                {
                    return NotFound();
                }
                return View(nutritionVM);
            }
        }

        //POST - EDIT
        [Authorize(Roles = "Administrator, User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NutritionVM model)
        {
            if (ModelState.IsValid)
            {
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
                return RedirectToAction("Index");
            }
            return View(model);

        }

        //GET - DELETE
        [Authorize("Administrator")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var food = db.Food.Find(id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        //POST - DELETE
        [Authorize("Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
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
            return RedirectToAction("Index");
        }
    }
}
