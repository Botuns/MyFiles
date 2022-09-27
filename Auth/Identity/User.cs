using Auth.Models.Base;
using System.Collections;
using System.Collections.Generic;

namespace Auth.Identity
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string UserName { get; set; }
        public string EmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
