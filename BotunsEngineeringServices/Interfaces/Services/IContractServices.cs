using BotunsEngineeringServices.DTOs;
using BotunsEngineeringServices.DTOs.ClientsDTO;
using BotunsEngineeringServices.DTOs.ContractDTO;
using BotunsEngineeringServices.Entities;

namespace BotunsEngineeringServices.Interfaces.Services
{
    public interface IContractServices
    {
        public BaseResponseModel<Contract> CreateContract(CreateContractRequestModel request);
    }
}
