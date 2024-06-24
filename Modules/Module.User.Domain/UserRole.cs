using Shared.Instrastructure;

namespace Module.User.Domain
{
    public class UserRole : Entity
    {

        public long UserId { get; set; }

        public long RoleId { get; set; }


        public User User { get; set; }

        public Role Role { get; set; }


    }
}