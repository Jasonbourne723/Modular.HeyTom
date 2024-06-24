using Shared.Instrastructure;

namespace Module.User.Domain
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}