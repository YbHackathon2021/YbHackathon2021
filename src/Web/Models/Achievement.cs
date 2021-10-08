using System;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class Achievement : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
