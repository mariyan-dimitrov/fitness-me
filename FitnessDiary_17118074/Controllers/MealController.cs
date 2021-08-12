using FitnessDiary_17118074.Data;
using FitnessDiary_17118074.Models;
using FitnessDiary_17118074.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Controllers
{
    [Authorize]
    public class MealController : Controller
    {
        private readonly FitnessDiaryDbContext db;

        public MealController(FitnessDiaryDbContext _db)
        {
            db = _db;
        }

        public string loggedUser()
        {
            var userName = User.Identity.Name;
            var userId = from u in db.Users
                         where u.UserName == userName
                         select u.Id;
            string user = (userId.FirstOrDefault() ?? "").ToString();

            return user;
        }
        public IActionResult Index()
        {
            double calories = 0;
            var user = loggedUser();
            var today = DateTime.UtcNow.ToString("MM/dd/yyyy");


            var objectList = db.Meal.Include(o => o.Food)
                             .Where(c => c.UserId == user)
                             .Where(c => EF.Functions.DateDiffDay(c.Date, DateTime.Parse(today)) == 0);

            foreach(var obj in objectList){
                calories += obj.Food.Calories * obj.Portion;
            }
            ViewData["DailyCalories"] = calories;

            return View(objectList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            MealVM model = new MealVM();
            model.Foods = db.Food.ToList();

            return View(model);
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MealVM model)
        {
            var user = loggedUser();

            if (ModelState.IsValid)
            {
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

                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            MealVM mealVM = new MealVM();

            if (id == null)
            {
                return View(mealVM);
            }
            else
            {
                mealVM.Meal = db.Meal.Find(id);
                mealVM.Foods = db.Food.ToList();

                if (mealVM.Meal == null)
                {
                    return NotFound();
                }
                return View(mealVM);
            }
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MealVM model)
        {
            var user = loggedUser();
            if (ModelState.IsValid)
            {
                Meal meal = db.Meal.Find(model.Meal.Id);

                meal.UserId = user;
                meal.FoodId = model.Meal.FoodId;
                meal.Date = model.Meal.Date;
                meal.Portion = model.Meal.Portion;
                meal.Type = model.Meal.Type;
                meal.UpdatedAt_17118074 = DateTime.UtcNow;

                db.Meal.Update(meal);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var food = db.Meal.Include(o => o.Food).FirstOrDefault(x => x.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMeal(int? id)
        {
            var meal = db.Meal.Find(id);

            if (meal == null)
            {
                return NotFound();
            }
            db.Meal.Remove(meal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
