using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class SupplierService : BaseService<Supplier>, ISupplierService
    {
        public SupplierService(ApplicationDbContext dbContext, ILogger<SupplierService> logger) : 
            base(dbContext, logger)
        {
        }

        public ActionResult<Supplier> Create(Supplier supplier)
        {
            var added = dbContext.Suppliers.Add(supplier);
            dbContext.SaveChanges();
            return added.Entity;
        }

        public ActionResult<Supplier> Update(Supplier supplier)
        {
            var updated = dbContext.Suppliers.Update(supplier);
            dbContext.SaveChanges();
            return updated.Entity;
        }
    }
}
