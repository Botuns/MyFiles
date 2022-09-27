using BotunsEntities.Identity;
using BotunsEntities.Interfaces.Repository;
using BotunsEntities.Context;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BotunsEntities.Implementations.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        //public UserRepository(ApplicationContext context)
        //{
        //    _context = context;
        //}
        public async Task<User> GetEmail(string email)
        {
            var ans = await _context.Users.SingleOrDefaultAsync(e => e.Email == email);
            return ans;
        }
    }
}
