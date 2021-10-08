using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IBaseService<TEntity, TResponseModel>
        where TEntity : BaseEntity
        where TResponseModel : class
    {
        IList<TResponseModel> GetAll();
        IList<TResponseModel> GetAll(Expression<Func<TEntity, bool>> filter);
        ActionResult<TResponseModel> GetById(Guid id);
    }
}
