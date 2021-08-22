using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessMe_15118078.Models
{
    public partial class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public double Calories { get; set; }
        public DateTime? CreatedAt_15118078 { get; set; }
        public DateTime? UpdatedAt_15118078 { get; set; }
    }
}
