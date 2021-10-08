using System;
using static YbHackathon.Solutioneers.Web.Models.Enum;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class Challenge : BaseEntity
    {
        public Topic Topic { get; set; }
        public string Title { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
        public string Description { get; set; }
        public int PointsToEarn { get; set; }
        public DateTime OpenFrom { get; set; }
        public DateTime OpenTo { get; set; }
    }
}
