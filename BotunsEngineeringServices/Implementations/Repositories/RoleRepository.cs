using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Interfaces.Repositories;
using System.Linq;

namespace BotunsEngineeringServices.Implementations.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationContext _context;
        public RoleRepository(ApplicationContext context)
        {
            _context = context;
        }
        
        public Role CreateRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role;
        }

        public Role ExistsByName(string name)
        {
            var roles = _context.Roles.FirstOrDefault(x => x.Name.Equals(name));
            return roles;
        }

        public Role ExistsById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
