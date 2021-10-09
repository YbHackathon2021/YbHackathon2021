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
            var foodTip = GetRandomTip(Enum.Topic.Food, tips);
            var homeTip = GetRandomTip(Enum.Topic.Home, tips);
            var stuffTip = GetRandomTip(Enum.Topic.Stuff, tips);
            var travelTip = GetRandomTip(Enum.Topic.Travel, tips);

            List<Tip> result = new();

            if (foodTip is not null) { result.Add(foodTip); }
            if (homeTip is not null) { result.Add(homeTip); }
            if (stuffTip is not null) { result.Add(stuffTip); }
            if (travelTip is not null) { result.Add(travelTip); }

            return result;
        }

        private Tip GetRandomTip(Enum.Topic topic, List<Tip> allTips)
        {
            var tipsOfTopic = allTips.Where(t => t.Topic == topic).ToList();
            if (tipsOfTopic.Any())
            {
                return tipsOfTopic.ElementAt(RandomNumberGenerator.GetInt32(0, tipsOfTopic.Count - 1));
            }

            return null;
        }
    }
}
