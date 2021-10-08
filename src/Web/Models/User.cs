using System.Collections.Generic;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class User : BaseEntity
    {
        public string ApplicationUserId { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<Score> Scores { get; set; }
        public List<UserChallenge> UserChallenges { get; set; }
    }
}
