using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FitnessDiary_17118074.Models.ViewModels
{
    public class MealVM
    {
        public List<Food> Foods { get; set; }
        public Meal Meal { get; set; }
    }
}
