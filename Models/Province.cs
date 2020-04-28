using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class Province
    {
        [Display(Name = "รหัสจังหวัด")]
        public int Id { get; set; }
        public string Code { get; set; }
        [Display(Name = "จังหวัด")]
        public string Name_th { get; set; }
        [Display(Name = "Province")]
        public string Name_en { get; set; }
        public int Geography_id { get; set; }
        public ICollection<Aumphure> Aumphures { get; }
        public ICollection<Receiver> Receivers { get; }
        public ICollection<UserDetail> UserDetails { get; }
    }
}
