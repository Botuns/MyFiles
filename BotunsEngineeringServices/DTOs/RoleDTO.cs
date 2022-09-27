using BotunsEngineeringServices.Entities;
using System.Collections.Generic;

namespace BotunsEngineeringServices.DTOs
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string RoleDescription { get; set; }

        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
    public class RoleReq
    {
        public string Name { get; set; }

        public string RoleDescription { get; set; }
    }
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public Admin Admin { get; set; }

        public Client Client { get; set; }

        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
    public class UserReq
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public string UserName { get; set; }
    }

}
