using BotunsEntities.Context;
using BotunsEntities.Entities;
using BotunsEntities.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotunsEntities.Implementations.Repositories
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        private readonly ApplicationContext _context;

        public AdminRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        //public AdminRepository(ApplicationContext context)
        //{
        //    _context = context;
        //}


        public async Task<Admin> GetAdminInfo(int id)
        {
            var admin = await _context.Admins
            .Include(x => x.User).Include(a => a.Address)
            .SingleOrDefaultAsync(x => x.User.Id == id && x.IsDeleted == false);
            return admin;
        }
        public async Task<IList<Admin>> GetAllAdminWithUser()
        {
            var admin = await _context.Admins.Include(x => x.User).Include(a => a.Address).Where(x => x.IsDeleted == false).ToListAsync();
            return admin;
        }

        public async Task<IList<Admin>> GetAllActivatedAdmin()
        {
            var admin = await _context.Admins.Where(x => x.IsDeleted == false).ToListAsync();
            return admin;
        }
        public async Task<IList<Admin>> GetAllDeactivatedAdmin()
        {
            var admin = await _context.Admins.Where(x => x.IsDeleted == true).ToListAsync();
            return admin;
        }

    }
    
}
