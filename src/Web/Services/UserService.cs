using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;
using Enum = YbHackathon.Solutioneers.Web.Models.Enum;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(ApplicationDbContext dbContext, ILogger<UserService> logger) : 
            base(dbContext, logger)
        {
        }

        public User Create(User user)
        {
            var added = dbContext.InternalUsers.Add(user);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public new User GetById(Guid id)
        {
            return dbContext.InternalUsers.Where(u => u.Id == id)
                .Include(u => u.Achievements)
                .Include(u => u.Scores)
                .FirstOrDefault();
        }

        public User GetByApplicationUserId(string id)
        {
            var user = dbContext.InternalUsers
                .Include(u => u.Achievements)
                .Include(u => u.Scores)
                .FirstOrDefault(iu => iu.ApplicationUserId == id);
            if (user != null) return user;

            var addedUser = dbContext.InternalUsers.Add(CreateInitial(id));

            dbContext.SaveChanges();

            return GetById(addedUser.Entity.Id);
        }

        public User Update(User user)
        {
            var updated = dbContext.InternalUsers.Update(user);
            dbContext.SaveChanges();
            return updated.Entity;
        }

        private User CreateInitial(string id)
        {
            return new User
            {
                ApplicationUserId = id,
                Scores = new List<Score>
                {
                    new Score
                    {
                        Topic = Enum.Topic.Food,
                        CurrentScore = 0
                    },
                    new Score
                    {
                        Topic = Enum.Topic.Home,
                        CurrentScore = 0
                    },
                    new Score
                    {
                        Topic = Enum.Topic.Stuff,
                        CurrentScore = 0
                    },
                    new Score
                    {
                        Topic = Enum.Topic.Travel,
                        CurrentScore = 0
                    }
                }
            };
        }
    }
}
