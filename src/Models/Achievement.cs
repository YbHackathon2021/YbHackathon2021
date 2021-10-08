using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Achievement
    {
        public Guid Id { get; set; }
        public Challenge Challenge { get; set; }
        public int PointsEarned { get; set; }
        public DateTime Date { get; set; }
    }
}
