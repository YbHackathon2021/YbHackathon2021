using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public ActionResult<Challenge> Create(Challenge challenge)
        {
            var added = dbContext.Challenges.Add(challenge);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public new ActionResult<Challenge> GetById(Guid id)
        {
            return dbContext.Challenges.Where(c => c.Id == id)
                .Include(c => c.Image)
                .FirstOrDefault();
        }

        public ActionResult<Challenge> Update(Challenge challenge)
        {
            var updated = dbContext.Challenges.Update(challenge);
            dbContext.SaveChanges();
            return updated.Entity;
        }
    }
}
