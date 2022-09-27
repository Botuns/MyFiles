using BotunsEngineeringServices.Entities;

namespace BotunsEngineeringServices.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public User CreateUser(User user);
        public User ExistsByEmail(string email);

        public User ExistsById(int id);

        public User GetByEmail(string email);
    }
}
