using BotunsEntities.Context;
using BotunsEntities.DTO;
using BotunsEntities.Entities;
using BotunsEntities.Implementations.Repositories;
using BotunsEntities.Interfaces.Repository;
using BotunsEntities.Interfaces.Service;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System.Threading.Tasks;

namespace BotunsEntities.Implementations.Services
{
    public class ContractService : IContractServices
    {
        private readonly IContractRepository _contractRepository;
        //private readonly IEmailSender _email;
        private readonly IUserRepository _userRepository;
        //private readonly IImageRepository _imageRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IWebHostEnvironment _webHost;
        public readonly IClientRepository _clientRepository;
        private readonly ApplicationContext _context;
        //private readonly ICategoryRepository _categoryRepository;
        public ContractService(IWebHostEnvironment webHost, IRoleRepository roleRepository, IAddressRepository addressRepository, IUserRepository userRepository, IContractRepository contractRepository, IClientRepository clientRepository, ApplicationContext context)
        {
            //_adminRepository = adminRepository;
            _userRepository = userRepository;
            _contractRepository = contractRepository;
            _clientRepository = clientRepository;
            _context = context;
            _addressRepository = addressRepository;
            _roleRepository = roleRepository;
            _webHost = webHost;

        }
        public Task<BaseResponseModels<ContractDTO>> GetClientContracts(int clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<BaseResponseModels<ContractDTO>> GetClientContracts(string clientId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BaseResponseModel<ContractDTO>> InitiateContract(InitiateContractRequest model)
        {
            var user = await _userRepository.Get(x => x.Id == model.userId);
            var client = await _clientRepository.Get(x => x.UserId == user.Id);
            var date = await _context.Contracts.FindAsync(model);
            if(model != null)
            {
                Contract contract = new Contract
            {
                HireType = model.HireType,
                ServiceType = model.ServiceType,
                ClientMessage = model.ClientMessage,
                ContractStatus = Enums.ContractStatus.Initiated,
                CreatedBy = client.Id,
                LastModifiedBy = client.Id,
                LastModifiedOn = date.ContractInitiatedDate,
                IsDeleted = false,
                ProjectProgress = 0,
                ClientId = client.Id,
            };
            await _contractRepository.Register(contract);
            }
           
            
            return new BaseResponseModel<ContractDTO>
            {
                IsSuccess = true,
                Message = "created Sucessfully",
            };

        }
    }
}

