
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IScoreService : IBaseService<Score>
    {
        Score Update(Score score);
        Score Create(Score score);
    }
}
