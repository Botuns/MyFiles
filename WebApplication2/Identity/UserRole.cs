using NETAUTH.Models.Base;

namespace NETAUTH.Identity
{
    public class UserRole : AuditableEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public string RoleId { get; set; }
        public Role Role { get; set; }
    }
}
