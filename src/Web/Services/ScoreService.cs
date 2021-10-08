using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class ScoreService : BaseService<Score>, IScoreService
    {
        public ScoreService(ApplicationDbContext dbContext, ILogger<ScoreService> logger) : 
            base(dbContext, logger)
        {
        }

        public Score Create(Score score)
        {
            var added = dbContext.Scores.Add(score);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public Score Update(Score score)
        {
            var updated = dbContext.Scores.Update(score);
            dbContext.SaveChanges();
            return updated.Entity;
        }
    }
}
