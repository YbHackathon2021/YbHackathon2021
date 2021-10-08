using System;
using static YbHackathon.Solutioneers.Web.Models.Enum;

namespace YbHackathon.Solutioneers.Web.Models
{
    public class UserChallenge : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ChallengeId { get; set; }
        public Challenge Challenge { get; set; }
        public UserChallengeState State { get; set; }
        public DateTime AcceptedAt { get; set; }
        public DateTime? ClosedAt { get; set; }

    }
}
