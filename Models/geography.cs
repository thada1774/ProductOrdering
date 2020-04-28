using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class geography
    {
        [Display(Name="รหัสภาค")]
        public int Id { get; set; }
        [Display(Name = "ภาค")]
        public string Name { get; set; }
    }
}
