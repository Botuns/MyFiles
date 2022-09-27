using BotunsEntities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<Client> GetCustomerWithUser(int id);

        Task<Client> GetCustomerInfo(int id);

        Task<IList<Client>> GetAllCustomersWithUser();

        Task<IList<Client>> GetContractsByCustomer(int id);

        //Task<IList<Customer>> GetAllVerifiedCustomers();

        //<IList<Customer>> GetNotVerifiedCustomers();
    }
    
    
}
