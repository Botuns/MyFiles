using BotunsEntities.Enums;
using Microsoft.AspNetCore.Http;

namespace BotunsEntities.DTO
{
    public class AdminDTO
    {
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
    public class AdminRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile Image { get; set; }
        public string City { get; set; }
        public string LGA { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
    public class UpdateAdminRequestModel
    {
        public IFormFile Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public string AddressDescription { get; set; }
        public string City { get; set; }
    }
    public class AdminLoginRequestModel
    {
        
        public string Email { get; set; }
        public string Password { get; set; }
    }


}
