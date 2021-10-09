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
    public class TipController : ControllerBase
    {
        private readonly ITipService _tipService;

        public TipController(ITipService tipService)
        {
            _tipService = tipService;
        }

        [HttpGet]
        public IEnumerable<Tip> Get()
        {
            return _tipService.GetAll();
        }
    }
}
