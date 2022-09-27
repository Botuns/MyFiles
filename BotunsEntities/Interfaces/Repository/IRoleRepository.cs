using BotunsEntities.Identity;
using System.Collections.Generic;

namespace BotunsEntities.Interfaces.Repository
{
    public interface IRoleRepository : IRepository<Role>
    {
        IList<Role> GetRolesByUserId(int id);
    }
}
