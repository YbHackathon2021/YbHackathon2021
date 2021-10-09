using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;
using Enum = YbHackathon.Solutioneers.Web.Models.Enum;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class TipService : BaseService<Tip>, ITipService
    {
        public TipService(ApplicationDbContext dbContext, ILogger<TipService> logger) : 
            base(dbContext, logger)
        {

        }

        public new IList<Tip> GetAll()
        {
            var tips = dbContext.Tips.ToList();

            var tip1 = tips.Where(t => t.Topic == Enum.Topic.Food).ElementAt(RandomNumberGenerator.GetInt32(0, tips.Count -1));
            var tip2 = tips.Where(t => t.Topic == Enum.Topic.Home).ElementAt(RandomNumberGenerator.GetInt32(0, tips.Count - 1));
            var tip3 = tips.Where(t => t.Topic == Enum.Topic.Stuff).ElementAt(RandomNumberGenerator.GetInt32(0, tips.Count - 1));
            var tip4 = tips.Where(t => t.Topic == Enum.Topic.Travel).ElementAt(RandomNumberGenerator.GetInt32(0, tips.Count - 1));

            return new List<Tip>
            {
                tip1,
                tip2,
                tip3,
                tip4
            };
        }
    }
}
