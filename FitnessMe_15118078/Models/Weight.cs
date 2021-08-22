using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessMe_15118078.Models
{
    public partial class Weight
    { 
        [Key]
        public int Id { get; set; }

        [Display(Name = "User")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser IdentityUser { get; set; }
        public double Mass { get; set; }
        public DateTime Day { get; set; }
        public DateTime? CreatedAt_15118078 { get; set; }
        public DateTime? UpdatedAt_15118078 { get; set; }
    }
}
