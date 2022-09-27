using BotunsEngineeringServices.Enums;

namespace BotunsEngineeringServices.Entities
{
    public class Admin 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public User user { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
