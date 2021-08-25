using System;

namespace FitnessMe_15118078.Models.ViewModels
{
    public class DisplayMealViewModel
    {
        public int Id { get; set; }

        public int FoodId { get; set; }

        public double Portion { get; set; }
        
        public DateTime Date { get; set; }
    }
}