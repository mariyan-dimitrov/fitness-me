using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Models
{
    public partial class Meal
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Food")]
        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public virtual Food Food { get; set; }

        [Display(Name = "User")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser IdentityUser { get; set; }

        [Required]
        public double Portion { get; set; }
        public string Type { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public DateTime? CreatedAt_17118074 { get; set; }
        public DateTime? UpdatedAt_17118074 { get; set; }
    }
}
