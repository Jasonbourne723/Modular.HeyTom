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
}