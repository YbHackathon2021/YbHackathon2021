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
    public class BaseService<TEntity, TResponseModel> : IBaseService<TEntity, TResponseModel> where TResponseModel : class where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext dbContext;
        protected readonly IMapper mapper;
        protected readonly ILogger logger;

        public BaseService(ApplicationDbContext dbContext, IMapper mapper, ILogger logger)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.logger = logger;
        }

        public IList<TResponseModel> GetAll()
        {
            var entities = dbContext.Set<TEntity>().ToList();
            return mapper.Map<IList<TResponseModel>>(entities);
        }

        public IList<TResponseModel> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            var entities = dbContext.Set<TEntity>().Where(filter).ToList();
            return mapper.Map<IList<TResponseModel>>(entities);
        }

        public ActionResult<TResponseModel> GetById(Guid id)
        {
            var entity = dbContext.Find<TEntity>(id);
            return mapper.Map<TResponseModel>(entity);
        }
    }
}
