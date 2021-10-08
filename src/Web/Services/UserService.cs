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
    }
}
