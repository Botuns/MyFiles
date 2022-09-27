using BotunsEntities.Identity;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        public  Task<User> GetEmail(string email);
    }
}
