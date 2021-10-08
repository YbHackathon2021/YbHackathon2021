using System.Collections.Generic;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class User : BaseEntity
    {
        public string ApplicationUserId { get; set; }
        public List<Achievement> Achievements { get; set; } = new List<Achievement>();
        public List<Score> Scores { get; set; } = new List<Score>();
        public List<UserChallenge> UserChallenges { get; set; } = new List<UserChallenge>();
    }
}
