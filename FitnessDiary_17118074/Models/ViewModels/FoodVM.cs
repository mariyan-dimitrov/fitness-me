using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Models.ViewModels
{
    public class FoodVM
    {
        public IEnumerable<Food> Foods { get; set; }
        public Nutrition Nutrition { get; set; }
    }
}
