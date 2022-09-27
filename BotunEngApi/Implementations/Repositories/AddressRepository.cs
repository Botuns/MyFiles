using BotunsEngApi.Contexts;
using BotunsEngApi.Entities;
using System.Linq;

namespace BotunsEngApi.Implementations.Repositories
{
    public class AddressRepository
    {
        private readonly ApplicationContext _context;
        public AddressRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Address CreateAddres(Address address)
        {
            
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address;

        }
        
        public Address UpdateAddress(Address address)
        {

            _context.Addresses.Update(address);
            _context.SaveChanges();
            return address;

        }
        public Address GetAddress(int id)
        {
            var address = _context.Addresses.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return address;
        }
    }
}
