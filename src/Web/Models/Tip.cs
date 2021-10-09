using System;
using static YbHackathon.Solutioneers.Web.Models.Enum;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class Tip : BaseEntity
    {
        public string Title { get; set; }

        public Topic Topic { get; set; }

        public string Teaser { get; set; }

        public string Url { get; set; }

        public string ImageUrl { get; set; }
    }
}
