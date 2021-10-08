using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

        public ActionResult<Achievement> Create(Achievement achievement)
        {
            var added = dbContext.Achievements.Add(achievement);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public ActionResult<Achievement> Update(Achievement achievement)
        {
            var updated = dbContext.Achievements.Update(achievement);
            dbContext.SaveChanges();
            return updated.Entity;
        }
    }
}
