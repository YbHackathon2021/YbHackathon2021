using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YbHackathon.Solutioneers.Models.Enum;

namespace YbHackathon.Solutioneers.Models
{
    public class Score
    {
        public Guid Id { get; set; }
        public Topic Topic { get; set; }
        public int CurrentScore { get; set; }
    }
}
