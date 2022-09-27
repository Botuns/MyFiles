using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Interfaces.Repositories;

namespace BotunsEngineeringServices.Implementations.Repositories
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
