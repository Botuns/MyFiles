using BotunsEngApi.Contexts;
using BotunsEngApi.Entities;
using BotunsEngApi.Interfaces.Repositories;

namespace BotunsEngApi.Implementations.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly ApplicationContext _context;
        public ContractRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Contract CreateContract(Contract contract)
        {
            _context.Contracts.Add(contract);
            _context.SaveChanges();
            return contract;
        }
    }
}
