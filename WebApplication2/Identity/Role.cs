using Microsoft.AspNetCore.Identity;
using NETAUTH.Models.Base;
using System.Collections.Generic;

namespace NETAUTH.Identity
{
    public class Role : AuditableEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
