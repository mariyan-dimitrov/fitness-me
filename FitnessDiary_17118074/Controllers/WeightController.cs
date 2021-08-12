using FitnessDiary_17118074.Data;
using FitnessDiary_17118074.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FitnessDiary_17118074.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/weight")]
    public class WeightController : Controller
    {
        private readonly FitnessDiaryDbContext db;

        public WeightController(FitnessDiaryDbContext _db)
        {
            db = _db;
        }

        [HttpPost]
        public IActionResult CreateWeight(Weight model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var user = GetUser();

            Weight weight = new Weight();
            weight.UserId = user;
            weight.Mass = model.Mass;
            weight.Day = model.Day;
            weight.CreatedAt_17118074 = DateTime.UtcNow;
            weight.UpdatedAt_17118074 = DateTime.UtcNow;

            db.Weight.Add(weight);
            db.SaveChanges();

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetWeight(int id)
        {
            var weight = db.Weight.Find(id);

            if (weight == null)
            {
                return NotFound();
            }
            return Ok(weight);
        }

        [HttpPut]
        public IActionResult UpdateWeight(Weight model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var user = GetUser();

            Weight weight = db.Weight.Find(model.Id);
            weight.UserId = user;
            weight.Mass = model.Mass;
            weight.Day = model.Day;
            weight.UpdatedAt_17118074 = DateTime.UtcNow;

            db.Weight.Update(weight);
            db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteWeight(int id)
        {
            var weight = db.Weight.Find(id);

            if (weight == null)
            {
                return NotFound();
            }

            db.Weight.Remove(weight);
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
