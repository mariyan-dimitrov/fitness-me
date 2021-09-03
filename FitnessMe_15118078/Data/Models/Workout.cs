using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FitnessMe_15118078.Data.Models
{
    public class Workout
    { 
        [Key]
        public int Id { get; set; }

        [Display(Name = "User")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser IdentityUser { get; set; }

        public int CategoryId { get; set; }

        public double Distance { get; set; }

        public DateTime Date { get; set; }

        public DateTime? CreatedAt_15118078 { get; set; }

        public DateTime? UpdatedAt_15118078 { get; set; }
    }
}
