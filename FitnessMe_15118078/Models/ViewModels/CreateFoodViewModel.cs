using System.ComponentModel.DataAnnotations;

namespace FitnessMe_15118078.Models.ViewModels
{
    public class CreateFoodViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public double Protein { get; set; }

        [Required]
        public double Carbs { get; set; }

        [Required]
        public double Fats { get; set; }
    }
}