
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface ISupplierService : IBaseService<Supplier>
    {
        ActionResult<Supplier> Update(Supplier supplier);
        ActionResult<Supplier> Create(Supplier supplier);
    }
}
