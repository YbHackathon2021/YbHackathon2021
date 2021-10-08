using AutoMapper;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class AchievementService : BaseService<Achievement>, IAchievementService
    {
        public AchievementService(ApplicationDbContext dbContext, ILogger<AchievementService> logger) : 
            base(dbContext, logger)
        {
        }
    }
}
