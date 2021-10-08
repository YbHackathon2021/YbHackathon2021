using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Exceptions;
using YbHackathon.Solutioneers.Web.Extensions;
using YbHackathon.Solutioneers.Web.Models;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserChallengesController : ControllerBase
    {
        private readonly IUserChallengeService _userChallengeService;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserChallengesController(IUserChallengeService userChallengeService, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _userChallengeService = userChallengeService;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }

        [HttpPost("challenge/{challengeId}")]
        public ActionResult<UserChallenge> Accept([FromRoute] Guid challengeId)
        {
            var identity = _httpContextAccessor.HttpContext.User;

            var appUserId = identity.GetId();

            var user = _userService.GetByApplicationUserId(appUserId);

            var acceptedChallenge = _userChallengeService.Accept(user.Id, challengeId);

            return Ok(acceptedChallenge);
        }

        [HttpPost("{id}/loose")]
        public ActionResult<UserChallenge> Loose([FromRoute] Guid id)
        {
            try
            {
                return _userChallengeService.Loose(id);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost("{id}/win")]
        public ActionResult<UserChallenge> WinChallenge([FromRoute] Guid id)
        {
            try
            {
                return _userChallengeService.Win(id);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }

        }
    }
}
