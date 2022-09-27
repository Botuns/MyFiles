using Authentication.Contexts;
using Authentication.Entities;

namespace Authentication.Interfaces.Repository
{
    public interface IUserRepository
    {
        public User Add(User user);
        public void Delete(int userId);
        public User FindById(int userId);
        public User FindByEmail(string userEmail);
        public User FindByUsername(string username);
        public User Update(User user);

    }
}
