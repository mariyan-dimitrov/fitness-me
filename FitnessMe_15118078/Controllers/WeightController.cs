using FitnessMe_15118078.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using FitnessMe_15118078.Data.Models;
using FitnessMe_15118078.Models.ViewModels;

namespace FitnessMe_15118078.Controllers
{
    [Route("api/weight")]
    public class WeightController : BaseAuthorizeController
    {
        private readonly FitnessMeDbContext _dbContext;

        public WeightController(FitnessMeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult CreateWeight(CreateWeightViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var weight = new Weight
            {
                Mass = model.Mass,
                Day = model.Day,
                CreatedAt_15118078 = DateTime.UtcNow,
                UpdatedAt_15118078 = DateTime.UtcNow,
                UserId = GetUserId()
            };

            _dbContext.Weight.Add(weight);
            _dbContext.SaveChanges();

            return Ok(weight.Id);
        }

        [HttpGet]
        public IActionResult GetWeight()
        {
            var weights = _dbContext.Weight.Where(w => w.UserId == GetUserId())
                .Select(w => new DisplayWeightViewModel()
                {
                    Id = w.Id,
                    Day = w.Day,
                    Mass = w.Mass
                }).ToArray();

            return Ok(weights);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateWeight(int id, CreateWeightViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            Weight weight = _dbContext.Weight.Find(id);
            if (weight is null)
            {
                return NotFound();
            }

            weight.UserId = GetUserId();
            weight.Mass = model.Mass;
            weight.Day = model.Day;
            weight.UpdatedAt_15118078 = DateTime.UtcNow;

            _dbContext.Weight.Update(weight);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWeight(int id)
        {
            var weight = _dbContext.Weight.Find(id);
            if (weight == null)
            {
                return NotFound();
            }

            _dbContext.Weight.Remove(weight);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
