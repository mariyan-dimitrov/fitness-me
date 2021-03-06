using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FitnessMe_15118078.Data.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public virtual Food Food { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser IdentityUser { get; set; }

        [Required]
        public double Portion { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public DateTime? CreatedAt_15118078 { get; set; }

        public DateTime? UpdatedAt_15118078 { get; set; }
    }
}
