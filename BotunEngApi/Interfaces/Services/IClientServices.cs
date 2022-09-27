using BotunsEngApi.DTOs;
using BotunsEngApi.DTOs.ClientsDTO;
using BotunsEngApi.DTOs.ContractDTO;
using BotunsEngApi.DTOs.WorkerDTO;
using BotunsEngApi.Entities;
using System.Collections.Generic;

namespace BotunsEngApi.Interfaces.Services
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

    }
}
