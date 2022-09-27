using BotunsEntities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Repository
{
    public interface IAdminRepository : IRepository<Admin>
    {

        Task<Admin> GetAdminInfo(int id);

        Task<IList<Admin>> GetAllAdminWithUser();

        Task<IList<Admin>> GetAllActivatedAdmin();

        Task<IList<Admin>> GetAllDeactivatedAdmin();
    }

    
}
