using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsEnabled { get; set; }
        public UserDetail UserDetail { get; set; }
        public ICollection<Ordering> Orderings { get; }

    }
}
