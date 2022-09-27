using System.Collections.Generic;

namespace BotunsEngineeringServices.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public Admin Admin { get; set; }

        public Client Client { get; set; }

        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
