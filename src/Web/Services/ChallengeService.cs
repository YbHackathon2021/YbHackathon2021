using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class ChallengeService : BaseService<Challenge>, IChallengeService
    {
        private readonly IUserChallengeService _userChallengeService;

        public ChallengeService(ApplicationDbContext dbContext, ILogger<ChallengeService> logger, IUserChallengeService userChallengeService) :
            base(dbContext, logger)
        {
            _userChallengeService = userChallengeService;
        }

        public Challenge Create(Challenge challenge)
        {
            var added = dbContext.Challenges.Add(challenge);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public new Challenge GetById(Guid id)
        {
            return dbContext.Challenges.Where(c => c.Id == id)
                .Include(c => c.Image)
                .FirstOrDefault();
        }

        public Challenge Update(Challenge challenge)
        {
            var updated = dbContext.Challenges.Update(challenge);
            dbContext.SaveChanges();
            return updated.Entity;
        }

        public IEnumerable<Challenge> GetAllNotStartedByCurrentUser(Guid userId)
        {
            var startedChallengesIds = _userChallengeService.GetAllByUserId(userId).Select(uc => uc.Challenge.Id);
            return dbContext.Challenges.Include(c => c.Image).Where(c => !startedChallengesIds.Contains(c.Id));
        }
    }
}
