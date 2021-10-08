using System;
using System.Collections.Generic;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IUserChallengeService : IBaseService<UserChallenge>
    {
        UserChallenge Accept(Guid userId, Guid challengeId);
        IEnumerable<UserChallenge> GetAllByUserId(Guid userId);
        UserChallenge Loose(Guid userChallengeId);
        UserChallenge Win(Guid userChallengeId);
    }
}
