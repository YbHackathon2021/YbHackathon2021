
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IChallengeService : IBaseService<Challenge>
    {
        Challenge Update(Challenge challenge);
        Challenge Create(Challenge challenge);
        IEnumerable<Challenge> GetAllNotStartedByCurrentUser(Guid userId);
    }
}
