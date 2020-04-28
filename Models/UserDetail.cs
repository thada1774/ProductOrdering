using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class UserDetail
    {
        public int UserDetailId { get; set; }
        [Display(Name = "ชื่อู้ใช้")]
        public string FirstName { get; set; }
        [Display(Name = "นามสกุลผู้ใช้")]
        public string LastName { get; set; }
        [Display(Name = "เบอร์โทร")]
        public string Tel { get; set; }
        [Display(Name = "ที่อยู่")]
        public string Address { get; set; }
        [Display(Name = "รหัสตำบล")]
        public int District_id { get; set; }
        public virtual District District { get; set; }
        [Display(Name = "รหัสอำเภอ")]
        public virtual Aumphure Aumphure { get; set; }
        public int Aumphure_id { get; set; }
        [Display(Name = "รหัสจังหวัด")]
        public virtual Province Province { get; set; }
        public int Province_id { get; set; }
        [Display(Name = "รหัสผู้ใช้")]
        public String UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
