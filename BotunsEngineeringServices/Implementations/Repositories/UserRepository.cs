using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Interfaces.Repositories;
using System.Linq;

namespace BotunsEngineeringServices.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public IUserRepository _userRepository;
        public UserRepository(ApplicationContext applicationContext, IUserRepository userRepository)
        {
            _context = applicationContext;
            _userRepository = userRepository;
        }
        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User ExistsByEmail(string email)
        {
            var user = _context.Users.Where(x => x.Email == email).FirstOrDefault();
            return user;
        }

        public User ExistsById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id.Equals(id));
            return user;
        }

        public User GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
