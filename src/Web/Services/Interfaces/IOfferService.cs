using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IOfferService : IBaseService<Offer>
    {
        Offer Update(Offer offer);
        Offer Create(Offer offer);
    }
}
