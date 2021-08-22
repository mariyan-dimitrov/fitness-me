using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessMe_15118078.Models
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
        public DateTime? CreatedAt_15118078 { get; set; }
        public DateTime? UpdatedAt_15118078 { get; set; }
    }
}
