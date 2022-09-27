using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.DTOs;
using BotunsEngineeringServices.DTOs.ContractDTO;
using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Interfaces.Repositories;
using BotunsEngineeringServices.Interfaces.Services;

namespace BotunsEngineeringServices.Implementations.Services
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
            var contract = _context.Contracts.Find(request.ContractDate);
            if (contract == null)
            {
                Contract contract1 = new Contract
                {
                    ContractDate = request.ContractDate,
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
                        ContractDate = request.ContractDate,
                        ClientMessage = request.ClientMessage,
                        ContractPrice = request.ContractPrice,
                        ContractDuration = request.ContractDuration,
                        HireType = request.HireType,
                        ServiceType = request.ServiceType,

                    },
                    IsSuccess = true,
                    Message = "Unsucessful!",

                };
            }
            return new BaseResponseModel<Contract>
            {
                IsSuccess = false,
                Message = "Sucessful!",


            };
            
        }
    }
}
