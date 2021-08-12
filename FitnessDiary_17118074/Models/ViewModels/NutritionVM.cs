using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Models.ViewModels
{
    public class NutritionVM
    {
        public Food Food { get; set; }
        public Nutrition Nutrition { get; set; }
    }
}
