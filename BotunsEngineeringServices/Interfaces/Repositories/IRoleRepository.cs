using BotunsEngineeringServices.Entities;

namespace BotunsEngineeringServices.Interfaces.Repositories
{
    public interface IRoleRepository
    {
        public Role CreateRole(Role role);  
        public Role ExistsByName(string name);

        public Role ExistsById(int id);

        //public Role GetByEmail(string email);

    }
}
