using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Models
{
    public partial class Nutrition
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Food")]
        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public virtual Food Food { get; set; }
        [Required]
        public string Protein { get; set; }
        [Required]
        public string Carbohydrates { get; set; }
        [Required]
        public string Fats { get; set; }
        public DateTime? CreatedAt_17118074 { get; set; }
        public DateTime? UpdatedAt_17118074 { get; set; }
    }
}
