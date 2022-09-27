using BotunsEngineeringServices.DTOs;
using BotunsEngineeringServices.DTOs.ClientsDTO;
using BotunsEngineeringServices.DTOs.ContractDTO;
using BotunsEngineeringServices.DTOs.WorkerDTO;
using BotunsEngineeringServices.Entities;
using System.Collections.Generic;

namespace BotunsEngineeringServices.Interfaces.Services
{
    public interface IClientServices
    {
        public BaseResponseModel<Client> CreateClient(ClientRequestModel request);
        public BaseResponseModel<Client> UpdateClient(ClientRequestModel request);
        public BaseResponseModel<Client> DeleteClient(int Id);
        public BaseResponseModel<Client> GetClientByEmailandPassword(string email, string password);
        public BaseResponseModel<Client> GetClientById(int Id);
        public BaseResponseModels<ContractDTO> GetClientContracts(int clientId);
        public BaseResponseModels<WorkerDTO> GetAllClientWorkers(int clientId);
        public BaseResponseModel<Contract> CreateContract(CreateContractRequestModel request);
        public BaseResponseModel<ClientDTO> LogIn(ClientLoginRequestModel model);

    }
}
