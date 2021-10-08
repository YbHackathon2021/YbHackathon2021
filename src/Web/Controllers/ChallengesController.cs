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
    public class ChallengesController : ControllerBase
    {
        private readonly IChallengeService _challengeService;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ChallengesController(IChallengeService challengeService, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _challengeService = challengeService;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<Challenge> Create([FromBody] Challenge challenge)
        {
            return _challengeService.Create(challenge);
        }

        [HttpGet]
        public IEnumerable<Challenge> Get()
        {
            return _challengeService.GetAll();
        }

        [HttpGet("userNotStarted")]
        public IEnumerable<Challenge> GetAllNotStartedByCurrentUser()
        {
            var identity = _httpContextAccessor.HttpContext.User;

            var appUserId = identity.GetId();

            var user = _userService.GetByApplicationUserId(appUserId);

            return _challengeService.GetAllNotStartedByCurrentUser(user.Id);
        }

        [HttpGet("{id}")]
        public ActionResult<Challenge> GetById([FromRoute] Guid id)
        {
            var challenge = _challengeService.GetById(id);
            if (challenge == null)
            {
                return NotFound();
            }

            return challenge;
        }

        [HttpPut]
        public ActionResult<Challenge> Update([FromBody] Challenge challenge)
        {
            return _challengeService.Update(challenge);
        }
    }
}
