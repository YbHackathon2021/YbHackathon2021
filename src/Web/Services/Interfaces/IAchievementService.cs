using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IAchievementService : IBaseService<Achievement>
    {
        Achievement Update(Achievement achievement);
        Achievement Create(Achievement achievement);
    }
}
