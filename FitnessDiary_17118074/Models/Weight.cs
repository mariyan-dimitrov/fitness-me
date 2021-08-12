using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Models
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
        public DateTime? CreatedAt_17118074 { get; set; }
        public DateTime? UpdatedAt_17118074 { get; set; }
    }
}
