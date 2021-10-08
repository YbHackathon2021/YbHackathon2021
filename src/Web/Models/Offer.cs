using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YbHackathon.Solutioneers.Web.Models.Enum;


namespace YbHackathon.Solutioneers.Web.Models
{
    public class Offer : BaseEntity
    {
        public Topic Topic { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
        public int SustainabilityRank { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
