
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface ISupplierService : IBaseService<Supplier>
    {
        Supplier Update(Supplier supplier);
        Supplier Create(Supplier supplier);
    }
}
