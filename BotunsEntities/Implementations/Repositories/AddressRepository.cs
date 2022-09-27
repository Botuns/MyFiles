using BotunsEntities.Context;
using BotunsEntities.Entities;
using BotunsEntities.Interfaces.Repository;

namespace BotunsEntities.Implementations.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        private readonly ApplicationContext _context;

        public AddressRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
        //public AddressRepository(ApplicationContext context)
        //{
        //    _context = context;
        //}

    }
}
