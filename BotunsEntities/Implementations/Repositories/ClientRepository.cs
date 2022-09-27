using BotunsEntities.Context;
using BotunsEntities.Entities;
using BotunsEntities.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BotunsEntities.Implementations.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ApplicationContext _context { get; }
        public ClientRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        

        public async Task<IList<Client>> GetAllCustomerWithUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Client>> GetContractsByCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Client> GetCustomerInfo(int id)
        {
            var client = await _context.Clients
            .Include(x => x.User).Include(a => a.Address)
            .SingleOrDefaultAsync(x => x.User.Id == id && x.IsDeleted == false);
            return client;
        }

        public Task<Client> GetCustomerWithUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Client>> GetAllCustomersWithUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
