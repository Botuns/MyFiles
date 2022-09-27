using System.Collections.Generic;

namespace BotunsEngineeringServices.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string RoleDescription { get; set; }

        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
