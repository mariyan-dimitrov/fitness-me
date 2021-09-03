using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessMe_15118078.Models.ViewModels
{
    public class CreateWorkoutViewModel
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public double Distance { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}