using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.Entities;

namespace BotunsEngineeringServices.Implementations.Repositories
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
    }
}
