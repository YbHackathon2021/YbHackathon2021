using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IOfferService : IBaseService<Offer>
    {
        ActionResult<Offer> Update(Offer offer);
        ActionResult<Offer> Create(Offer offer);
    }
}
