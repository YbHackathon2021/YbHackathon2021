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
            return _challengeService.GetAllNotStartedByCurrentUser();
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

        [HttpPut]
        public ActionResult<Challenge> Update([FromBody] Challenge challenge)
        {
            return _challengeService.Update(challenge);
        }
    }
}
