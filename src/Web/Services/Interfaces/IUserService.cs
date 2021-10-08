using Microsoft.AspNetCore.Mvc;
using YbHackathon.Solutioneers.Web.Models;

namespace YbHackathon.Solutioneers.Web.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        User GetByApplicationUserId(string id);
        User Update(User user);
        User Create(User user);
    }
}
