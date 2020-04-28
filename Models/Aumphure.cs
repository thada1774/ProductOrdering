using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class Aumphure
    {
        [Display(Name = "รหัสอำเภอ")]
        public int Id { get; set; }
        public string Code { get; set; }
        [Display(Name = "อำเภอ")]
        public string Name_th { get; set; }
        [Display(Name = "Aumphure")]
        public string Name_en { get; set; }
        [Display(Name = "รหัสจังหวัด")]
        public int Province_id { get; set; }
        public Province Province { get; set; }
        public ICollection<District> Districts { get; }
        public ICollection<Receiver> Receivers { get; }
        public ICollection<UserDetail> UserDetails { get; }
    }
}
