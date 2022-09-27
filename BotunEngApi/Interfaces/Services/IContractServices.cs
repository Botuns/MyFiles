using BotunsEngApi.DTOs;
using BotunsEngApi.DTOs.ClientsDTO;
using BotunsEngApi.DTOs.ContractDTO;
using BotunsEngApi.Entities;

namespace BotunsEngApi.Interfaces.Services
{
    public interface IContractServices
    {
        public BaseResponseModel<Contract> CreateContract(CreateContractRequestModel request);
    }
}
