
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IScoreService : IBaseService<Score>
    {
        ActionResult<Score> Update(Score score);
        ActionResult<Score> Create(Score score);
    }
}
