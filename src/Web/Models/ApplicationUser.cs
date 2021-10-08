using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Achievement> Achievements { get; set; }
        public List<Score> Scores { get; set; }
    }
}
