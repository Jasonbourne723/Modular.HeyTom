using Shared.Instrastructure;

namespace Module.User.Domain
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }
    }


    public class Role : Entity
    {
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }


    public class UserRole : Entity
    {

        public long UserId { get; set; }

        public long RoleId { get; set; }


        public User User { get; set; }

        public Role Role { get; set; }


    }
}