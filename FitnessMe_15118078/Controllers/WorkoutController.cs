using FitnessMe_15118078.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using FitnessMe_15118078.Data.Models;
using FitnessMe_15118078.Models.ViewModels;

namespace FitnessMe_15118078.Controllers
{
    [Route("api/workout")]
    public class WorkoutController : BaseAuthorizeController
    {
        private readonly FitnessMeDbContext _dbContext;

        public WorkoutController(FitnessMeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult CreateWorkout(CreateWorkoutViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var workout = new Workout()
            {
                CategoryId = model.CategoryId,
                Distance = model.Distance,
                Date = model.Date,
                UserId = GetUserId(),
                CreatedAt_15118078 = DateTime.UtcNow,
                UpdatedAt_15118078 = DateTime.UtcNow
            };

            _dbContext.Workouts.Add(workout);
            _dbContext.SaveChanges();

            return Ok(workout.Id);
        }

        [HttpGet]
        public IActionResult GetWorkouts()
        {
            var workouts = _dbContext.Workouts.Where(w => w.UserId == GetUserId())
                                             .Select(w => new DisplayWorkoutViewModel
                                             {
                                                 Id = w.Id,
                                                 CategoryId = w.CategoryId,
                                                 Date = w.Date,
                                                 Distance = w.Distance
                                             }).ToArray();

            return Ok(workouts);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateWorkout(int id, CreateWorkoutViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            Workout workout = _dbContext.Workouts.Find(id);
            if (workout is null)
            {
                return NotFound();
            }

            workout.UserId = GetUserId();
            workout.CategoryId = model.CategoryId;
            workout.Distance = model.Distance;
            workout.Date = model.Date;
            workout.UpdatedAt_15118078 = DateTime.UtcNow;

            _dbContext.Workouts.Update(workout);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorkout(int id)
        {
            Workout workout = _dbContext.Workouts.Find(id);
            if (workout == null)
            {
                return NotFound();
            }

            _dbContext.Workouts.Remove(workout);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
