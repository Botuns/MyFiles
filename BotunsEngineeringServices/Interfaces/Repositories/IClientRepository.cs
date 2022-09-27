using BotunsEngineeringServices.DTOs.ContractDTO;
using BotunsEngineeringServices.DTOs.WorkerDTO;
using BotunsEngineeringServices.Entities;
using System.Collections.Generic;

namespace BotunsEngineeringServices.Interfaces.Repositories
{
    public interface IClientRepository
    {
        public Client CreateClient(Client client);
        public Client UpdateClient(Client client);
        public void DeleteClient(int Id);
        public Client GetClientByEmailandPassword(string email, string password);
        public Client GetClientById(int Id);
        public List<ContractDTO> GetClientContracts(int clientId);
        public List<WorkerDTO> GetAllClientWorkers(int id);

    }
}
