using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessMe_15118078.Models.ViewModels
{
    public class CreateMealViewModel
    {
        [Required]
        public int FoodId { get; set; }

        [Required]
        public double Portion { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
    }
}