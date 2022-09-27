using BotunsEntities.DTO;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Service
{
    public interface IContractServices
    {
        Task<BaseResponseModel<ContractDTO>> InitiateContract(InitiateContractRequest model);
        Task<BaseResponseModels<ContractDTO>> GetClientContracts(int clientId);
        Task<BaseResponseModels<ContractDTO>> GetClientContracts(string clientId);

    }
}
