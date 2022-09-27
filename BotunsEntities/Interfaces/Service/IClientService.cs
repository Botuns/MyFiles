using BotunsEntities.DTO;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Service
{
    public interface IClientService
    {
        Task<BaseResponseModel<ClientDTO>> RegisterClient(ClientRequestModel model);
        Task<BaseResponseModel<ClientDTO>> GetClientInfo(int id);
        
        //(Admin Function)Task<CustomersResponseModel> GetAllCustomers();
        
        Task<BaseResponseModels<ContractDTO>> GetContractsByClientId(int id);
        
        Task <int> NoOfOngoingProject(int clientId);
        Task<int> ProjectProgress(int clientId);






        //(Admin)Task<BaseResponse> VerifyCustomer(int id);

        //(Admin)Task<CustomerResponseModel> GetCustomerById(int id);

        //(Admin)Task<CustomersResponseModel> GetAllVerifiedCustomers();


    }
}
