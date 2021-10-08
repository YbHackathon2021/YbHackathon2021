using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public UserChallengesController(IUserChallengeService userChallengeService)
        {
            _userChallengeService = userChallengeService;
        }

        [HttpPost("challenge/{challengeId}")]
        public ActionResult<UserChallenge> Accept([FromQuery] Guid userId, [FromQuery] Guid challengeId)
        {
            return _userChallengeService.Accept(userId, challengeId);
        }

        [HttpPost("{id}/loose")]
        public ActionResult<UserChallenge> Loose([FromQuery] Guid id)
        {
            return _userChallengeService.Loose(id);
        }

        [HttpPost("{id}/win")]
        public ActionResult<UserChallenge> WinChallenge([FromQuery] Guid id)
        {
            return _userChallengeService.Win(id);
        }
    }
}
