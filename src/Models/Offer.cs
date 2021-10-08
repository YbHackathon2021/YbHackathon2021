using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Enum;


namespace Models
{
    public class Offer
    {
        public Guid Id { get; set; }
        public Topic Topic { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        // public Image Image { get; set; }
        public int SustainabilityRank { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
