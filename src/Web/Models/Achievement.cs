using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class Achievement : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
