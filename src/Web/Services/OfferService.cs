using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class OfferService : BaseService<Offer>, IOfferService
    {
        public OfferService(ApplicationDbContext dbContext, ILogger<OfferService> logger) : 
            base(dbContext, logger)
        {
        }

        public Offer Create(Offer offer)
        {
            var added = dbContext.Offers.Add(offer);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public Offer Update(Offer offer)
        {
            var updated = dbContext.Offers.Update(offer);
            dbContext.SaveChanges();
            return updated.Entity;
        }
    }
}
