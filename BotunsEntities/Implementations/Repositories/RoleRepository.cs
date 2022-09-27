using BotunsEntities.Context;
using BotunsEntities.Identity;
using BotunsEntities.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BotunsEntities.Implementations.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private readonly ApplicationContext _context;

        public RoleRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        //public RoleRepository(ApplicationContext context)
        //{
        //    _context = context;
        //}

        public IList<Role> GetRolesByUserId(int id)
        {
            var roles = _context.UserRoles?.Include(r => r.Role).Where(x => x.UserId == id).Select(r => new Role
            {
                Name = r.Role.Name,
                Description = r.Role.Description
            }).ToList();
#pragma warning disable CS8603 // Possible null reference return.
            return roles;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
