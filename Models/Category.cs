using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class Category
    {
        [Display(Name = "รหัสหมวดสินค้า")]
        public int CategoryId { get; set; }
        [Display(Name = "ชื่อหมวดสินค้า")]
        public string Name { get; set; }
        [Display(Name = "คำอธิบาย")]
        public string Description { get; set; }
        
        public ICollection<Product> Products { get; } 
    }
}
