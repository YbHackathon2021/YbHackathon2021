using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        ActionResult<User> Update(User user);
        ActionResult<User> Create(User user);
    }
}
