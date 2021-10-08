using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class ScoreService : BaseService<Score, Score>, IScoreService
    {
        public ScoreService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : 
            base(dbContext, mapper, logger)
        {
        }
    }
}
