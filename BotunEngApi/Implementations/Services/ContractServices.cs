using BotunsEngApi.Contexts;
using BotunsEngApi.DTOs;
using BotunsEngApi.DTOs.ContractDTO;
using BotunsEngApi.Entities;
using BotunsEngApi.Interfaces.Repositories;
using BotunsEngApi.Interfaces.Services;

namespace BotunsEngApi.Implementations.Services
{
    public class ContractServices : IContractServices
    {
        private readonly ApplicationContext _context;
        public IContractRepository _contractRepository;
        public ContractServices(ApplicationContext context, IContractRepository contractRepository )
        {
            _context = context;
            _contractRepository = contractRepository;
        }
        public BaseResponseModel<Contract> CreateContract(CreateContractRequestModel request)
        {
            
            if (request != null)
            {
                Contract contract1 = new Contract
                {
                    
                    ClientMessage = request.ClientMessage,
                    ContractPrice = request.ContractPrice,
                    ContractDuration = request.ContractDuration,
                    HireType = request.HireType,
                    ServiceType = request.ServiceType,
                };
                _contractRepository.CreateContract(contract1);
                return new BaseResponseModel<Contract>
                {
                    Data = new Contract
                    {
                        
                        ClientMessage = request.ClientMessage,
                        ContractPrice = request.ContractPrice,
                        ContractDuration = request.ContractDuration,
                        HireType = request.HireType,
                        ServiceType = request.ServiceType,

                    },
                    IsSuccess = true,
                    Message = "sucessful!",

                };
            }
            return new BaseResponseModel<Contract>
            {
                IsSuccess = false,
                Message = "UnSucessful!",


            };
            
        }
    }
}
