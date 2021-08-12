using FitnessDiary_17118074.Data;
using FitnessDiary_17118074.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Controllers
{
    [Authorize]
    public class WeightController : Controller
    {
        private readonly FitnessDiaryDbContext db;

        public WeightController(FitnessDiaryDbContext _db)
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

        public IActionResult Index(string sortOrder)
        {
            /*ViewData["WeightSortParm"] = sortOrder == "Weight" ? "weight_desc" : "Weight";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";*/
            var user = loggedUser();
            IEnumerable<Weight> objectList = db.Weight.Where(c => c.UserId == user);

            /*switch (sortOrder)
            {
                case "Weight":
                    objectList = objectList.OrderBy(s => s.Mass);
                    break;
                case "weight_desc":
                    objectList = objectList.OrderByDescending(s => s.Mass);
                    break;
                case "Date":
                    objectList = objectList.OrderBy(s => s.Day);
                    break;
                case "date_desc":
                    objectList = objectList.OrderByDescending(s => s.Day);
                    break;
                default:
                    objectList = objectList.OrderByDescending(s => s.Day);
                    break;
            }*/

            return View(objectList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Weight model)
        {
            var user = loggedUser();

            if (ModelState.IsValid)
            {
                Weight weight = new Weight();
                weight.UserId = user;
                weight.Mass = model.Mass;
                weight.Day = model.Day;
                weight.CreatedAt_17118074 = DateTime.UtcNow;
                weight.UpdatedAt_17118074 = DateTime.UtcNow;

                db.Weight.Add(weight);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            Weight weight = new Weight();

            if (id == null)
            {
                return View(weight);
            }
            else
            {
                weight = db.Weight.Find(id);

                if (weight == null)
                {
                    return NotFound();
                }
                return View(weight);
            }
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Weight model)
        {
            var user = loggedUser();

            if (ModelState.IsValid)
            {
                Weight weight = db.Weight.Find(model.Id);
                weight.UserId = user;
                weight.Mass = model.Mass;
                weight.Day = model.Day;
                weight.UpdatedAt_17118074 = DateTime.UtcNow;

                db.Weight.Update(weight);
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
            var weight = db.Weight.Find(id);
            if (weight == null)
            {
                return NotFound();
            }

            return View(weight);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteWeight(int? id)
        {
            var weight = db.Weight.Find(id);

            if (weight == null)
            {
                return NotFound();
            }

            db.Weight.Remove(weight);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
