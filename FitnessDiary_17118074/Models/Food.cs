using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Models
{
    public partial class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public double Calories { get; set; }
        public DateTime? CreatedAt_17118074 { get; set; }
        public DateTime? UpdatedAt_17118074 { get; set; }
    }
}
