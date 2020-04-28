using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class District
    {
        [Display(Name = "รหัสตำบล")]
        public int Id { get; set; }
        [Display(Name = "รหัสไปรษณีย์")]
        public int Zip_code { get; set; }
        [Display(Name = "ตำบล")]
        public string Name_th { get; set; }
        [Display(Name = "Tumbol")]
        public string Name_en { get; set; }
        [Display(Name = "รหัสอำเภอ")]
        public int Aumphure_id { get; set; }
        public Aumphure Aumphure { get; set; }
        public ICollection<Receiver> Receivers { get; }
        public ICollection<UserDetail> UserDetails { get; }

    }
}
