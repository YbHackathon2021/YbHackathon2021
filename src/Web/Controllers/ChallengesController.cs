using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public ChallengesController(IChallengeService challengeService)
        {
            _challengeService = challengeService;
        }

        [HttpGet]
        public IEnumerable<Challenge> Get()
        {
            return _challengeService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Challenge> GetById([FromQuery] Guid id)
        {
            var challenge = _challengeService.GetById(id);
            if (challenge == null)
            {
                return NotFound();
            }

            return challenge;
        }
    }
}
