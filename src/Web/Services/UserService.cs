﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YbHackathon.Solutioneers.Web.Data;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(ApplicationDbContext dbContext, ILogger<UserService> logger) : 
            base(dbContext, logger)
        {
        }

        public new ActionResult<User> GetById(Guid id)
        {
            return dbContext.InternalUsers.Where(u => u.Id == id)
                .Include(u => u.Achievements)
                .Include(u => u.Scores)
                .First();
        }
    }
}