using System;

namespace FitnessMe_15118078.Models.ViewModels
{
    public class DisplayWorkoutViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public double Distance { get; set; }

        public DateTime Date { get; set; }
    }
}