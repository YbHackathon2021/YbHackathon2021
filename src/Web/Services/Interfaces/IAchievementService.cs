using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IAchievementService : IBaseService<Achievement>
    {
        ActionResult<Achievement> Update(Achievement achievement);
        ActionResult<Achievement> Create(Achievement achievement);
    }
}
