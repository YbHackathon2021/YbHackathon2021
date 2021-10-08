using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        IList<TEntity> GetAll();
        IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        TEntity GetById(Guid id);
    }
}
