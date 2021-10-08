using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Exceptions;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class UserChallengeService : BaseService<UserChallenge>, IUserChallengeService
    {
        private readonly IChallengeService _challengeService;
        private readonly IUserService _userService;

        public UserChallengeService(ApplicationDbContext dbContext, ILogger<UserChallengeService> logger, IChallengeService challengeService, IUserService userService) : 
            base(dbContext, logger)
        {
            _challengeService = challengeService;
            _userService = userService;
        }

        public UserChallenge Accept(Guid userId, Guid challengeId)
        {
            var userChallenge = new UserChallenge
            { 
                AcceptedAt = DateTime.Now,
                Challenge = _challengeService.GetById(userId),
                State = Models.Enum.UserChallengeState.open,
                User = _userService.GetById(userId)
            };
            var added = dbContext.UserChallenges.Add(userChallenge);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public IEnumerable<UserChallenge> GetAllByUserId(Guid userId)
        {
            return dbContext.UserChallenges.Where(c => c.User.Id == userId)
                .Include(c => c.User)
                .Include(c => c.Challenge);
        }

        public UserChallenge Loose(Guid userChallengeId)
        {
            var userChallenge = dbContext.UserChallenges.Find(userChallengeId);
            if (userChallenge == null)
            {
                throw new EntityNotFoundException();
            }

            userChallenge.State = Models.Enum.UserChallengeState.lost;
            dbContext.SaveChanges();
            return userChallenge;
        }

        public UserChallenge Win(Guid userChallengeId)
        {
            var userChallenge = dbContext.UserChallenges.Find(userChallengeId);
            if (userChallenge == null)
            {
                throw new EntityNotFoundException();
            }

            userChallenge.State = Models.Enum.UserChallengeState.won;
            dbContext.SaveChanges();
            return userChallenge;
        }
    }
}
