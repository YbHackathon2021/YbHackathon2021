
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IChallengeService : IBaseService<Challenge>
    {
        ActionResult<Challenge> Update(Challenge challenge);
        ActionResult<Challenge> Create(Challenge challenge);
    }
}
