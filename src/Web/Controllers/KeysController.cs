using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace YbHackathon.Solutioneers.Web.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class KeysController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public KeysController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var key = _configuration.GetValue<string>("Tenor:ApiKey");
            return new List<string>
            {
                key
            };
        }
    }
}
