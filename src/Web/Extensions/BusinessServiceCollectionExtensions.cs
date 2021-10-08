using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using YbHackathon.Solutioneers.Web.Services;
using YbHackathon.Solutioneers.Web.Services.Interfaces;

namespace YbHackathon.Solutioneers.Web.Extensions
{
    public static class BusinessServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
