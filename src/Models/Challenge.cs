using System;
using static YbHackathon.Solutioneers.Models.Enum;

namespace YbHackathon.Solutioneers.Models
{
    public class Challenge
    {
        public Guid Id { get; set; }
        public Topic Topic { get; set; }
        public string Title { get; set; }
        public Image Image { get; set; }
        public string Description { get; set; }
        public int PointsToEarn { get; set; }
        public DateTime OpenFrom { get; set; }
        public DateTime OpenTo { get; set; }
    }
}
