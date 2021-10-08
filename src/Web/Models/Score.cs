using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YbHackathon.Solutioneers.Web.Models.Enum;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class Score : BaseEntity
    {
        public Topic Topic { get; set; }
        public int CurrentScore { get; set; }
    }
}
