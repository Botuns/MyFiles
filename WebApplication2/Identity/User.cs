using NETAUTH.Models.Base;
using NETAUTH.Models.Entities;
using System.Collections.Generic;

namespace NETAUTH.Identity
{
    public class User : AuditableEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
