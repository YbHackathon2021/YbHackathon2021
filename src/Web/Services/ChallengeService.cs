using AutoMapper;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class ChallengeService : BaseService<Challenge>, IChallengeService
    {
        public ChallengeService(ApplicationDbContext dbContext, ILogger<ChallengeService> logger) : 
            base(dbContext, logger)
        {
        }
    }
}
