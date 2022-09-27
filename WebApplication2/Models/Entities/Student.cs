using NETAUTH.Identity;
using NETAUTH.Models.Base;

namespace NETAUTH.Models.Entities
{
    public class Student : AuditableEntity
    {
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public int Age { get; set; }
        public string ?Email { get; set; }
        public string ?Phone { get; set; }
        public string ?UserId { get; set; }
        public User ?User { get; set; }
    }
}
