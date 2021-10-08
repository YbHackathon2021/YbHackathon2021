using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Enum;

namespace Models
{
    public class Challenge
    {
        public Guid Id { get; set; }
        public Topic Topic { get; set; }
        public string Title { get; set; }
        // public Image Image { get; set; }
        public string Description { get; set; }
        public int PointsToEarn { get; set; }
        public DateTime OpenFrom { get; set; }
        public DateTime OpenTo { get; set; }
    }
}
