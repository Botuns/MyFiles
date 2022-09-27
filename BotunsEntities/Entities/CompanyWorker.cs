#nullable disable

using BotunsEntities.Contracts;
using BotunsEntities.Identity;

namespace BotunsEntities.Entities
{
    public class CompanyWorker : AuditableEntity
    {
        
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool IsVerified { get; set; }
    }
}
