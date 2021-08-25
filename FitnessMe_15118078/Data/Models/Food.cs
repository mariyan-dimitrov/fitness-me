using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessMe_15118078.Data.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Protein { get; set; }

        [Required]
        public double Carbs { get; set; }

        [Required]
        public double Fats { get; set; }

        public double Calories { get; set; }

        public DateTime? CreatedAt_15118078 { get; set; }

        public DateTime? UpdatedAt_15118078 { get; set; }
    }
}
