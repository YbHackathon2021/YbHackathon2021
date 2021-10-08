using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YbHackathon.Solutioneers.Web.Models
{
    class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Image Logo { get; set; }
    }
}
