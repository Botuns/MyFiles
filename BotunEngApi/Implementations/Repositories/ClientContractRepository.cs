using BotunsEngApi.Contexts;
using BotunsEngApi.Entities;

namespace BotunEngApi.Implementations.Repositories
{
    public class ClientContractRepository
    {
        private readonly ApplicationContext _context;

        public ClientContractRepository(ApplicationContext context)
        {
            _context = context;
        }
        public ClientContracts CreateContracts(ClientContracts clientContracts)
        {
            var clientContract = new ClientContracts()
            {
                ClientId = clientContracts.ClientId,
                ContractId = clientContracts.ContractId,
            };
            _context.ClientContracts.Add(clientContract);
            _context.SaveChanges();
            return clientContract;

        }

    }
}
