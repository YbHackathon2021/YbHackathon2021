using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext dbContext;
        protected readonly ILogger<IBaseService<TEntity>> logger;

        public BaseService(ApplicationDbContext dbContext, ILogger<IBaseService<TEntity>> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        public IList<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return dbContext.Set<TEntity>().Where(filter).ToList();
        }

        public ActionResult<TEntity> GetById(Guid id)
        {
            return dbContext.Find<TEntity>(id);
        }
    }
}
