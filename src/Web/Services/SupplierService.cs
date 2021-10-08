using AutoMapper;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class SupplierService : BaseService<Supplier, Supplier>, ISupplierService
    {
        public SupplierService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : 
            base(dbContext, mapper, logger)
        {
        }
    }
}
