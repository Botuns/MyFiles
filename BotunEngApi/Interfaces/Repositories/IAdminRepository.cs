using BotunsEngApi.Entities;
using System.Collections.Generic;

namespace BotunsEngApi.Interfaces.Repositories
{
    public interface IAdminRepository
    {
        public Admin CreateAdmin(Admin admin);
        public Admin GetAdminById(int id);
        public IList<Admin> GetAdmins();

    }
}
