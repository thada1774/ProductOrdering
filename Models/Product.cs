using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class Product
    {
        [Display(Name = "รหัสสินค้า")]
        public int ProductId { get; set; }
        [Display(Name = "ชื่อสินค้า")]
        public string Name { get; set; }
        [Display(Name = "จำนวนสินค้าที่เหลือ")]
        public int Amount { get; set; }
        [Display(Name = "ราคา")]
        public decimal Price { get; set; }
        [Display(Name = "หมวดสินค้า")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Ordering> Orderings { get; }
    }
}
