using Auth.Models.Base;
using System.Collections.Generic;

namespace Auth.Identity
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
