using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.User.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module.User
{
    public static class Extensions
    {
        public static IServiceCollection AddUserContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")!)
            );
            return services;
        }
    }
}
