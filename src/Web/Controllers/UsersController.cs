using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Extensions;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsersController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public ActionResult<User> Create([FromBody] User user)
        {
            return _userService.Create(user);
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById([FromRoute] Guid id)
        {
            var user = _userService.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet("current")]
        public User GetCurrentUser()
        {
            var identity = _httpContextAccessor.HttpContext.User;

            var appUserId = identity.GetId();

            var user = _userService.GetByApplicationUserId(appUserId);

            return user;
        }

        [HttpPut]
        public ActionResult<User> Update([FromBody] User user)
        {
            return _userService.Update(user);
        }
    }
}
