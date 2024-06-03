using Microsoft.EntityFrameworkCore;
using Module.User.Domain;

namespace Module.User.Infrastructure
{
    public class UserContext : DbContext
    {
        /// <summary>
        /// UserContext
        /// </summary>
        /// <param name="options"></param>
        public UserContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Domain.User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }
    }
}