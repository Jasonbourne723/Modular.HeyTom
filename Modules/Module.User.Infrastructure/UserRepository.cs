using Microsoft.EntityFrameworkCore;
using Module.User.Domain;
using Shared.Instrastructure;

namespace Module.User.Infrastructure
{
    public class UserRepository : Repository<Domain.User>, IUserRepository
    {
        public UserRepository(UserContext dbContext) : base(dbContext)
        {
        }
    }
}