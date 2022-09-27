using BotunsEngineeringServices.Entities;
using System.Collections.Generic;

namespace BotunsEngineeringServices.Interfaces.Repositories
{
    public interface IAdminRepository
    {
        public Admin CreateAdmin(Admin admin);
        public Admin GetAdminById(int id);
        public IList<Admin> GetAdmins();

    }
}
