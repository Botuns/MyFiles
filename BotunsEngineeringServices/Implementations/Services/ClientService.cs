using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.DTOs;
using BotunsEngineeringServices.DTOs.ClientsDTO;
using BotunsEngineeringServices.DTOs.ContractDTO;
using BotunsEngineeringServices.DTOs.WorkerDTO;
using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Implementations.Repositories;
using BotunsEngineeringServices.Interfaces.Repositories;
using BotunsEngineeringServices.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace BotunsEngineeringServices.Implementations.Services
{
    // Still to add -- Profile pic, 
    public class ClientService : IClientServices
    {
        private readonly ApplicationContext _context;
        public IClientRepository _clientRepository;
        //public IContractServices _contractServices;
        public IContractRepository _contractRepository;
        public AddressRepository _addressRepository;
        public ClientService(ApplicationContext context, IClientRepository clientRepository, AddressRepository addressRepository, IContractRepository contractRepository)
        {
            _context = context;
            _clientRepository = clientRepository;
            _addressRepository = addressRepository;
            _contractRepository = contractRepository;
            
        }
        public BaseResponseModel<Client> CreateClient(ClientRequestModel request)
        {
            
            var client = _clientRepository.GetClientByEmailandPassword(request.Email, request.Password);
            if(client != null)
            {
                return new BaseResponseModel<Client>
                {
                    IsSuccess = false,
                    Message = "User Already Exists",
                    
                };
            }
            
            else
            {
                Address address = new Address
                {
                    Country = request.Country,
                    State = request.State,
                    LocalGovernment = request.LocalGovernment,
                    Town = request.Town,

                };
                _addressRepository.CreateAddres(address);
                Client clients = new Client
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Password = request.Password,
                    PhoneNumber = request.PhoneNumber,
                    Gender = request.Gender,
                    AddressId = address.Id,
                    Address = address,
                };
                
                _clientRepository.CreateClient(clients);
                
            }
            return new BaseResponseModel<Client>
            {
                Data = new Client
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Gender = request.Gender,
                    
                },
                IsSuccess = true,
                Message = "Client Registered sucessfully",
                
            };
            
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

        public BaseResponseModel<Client> DeleteClient(int Id)
        {
            var client = _clientRepository.GetClientById(Id);
            if( client == null)
            {
                return new BaseResponseModel<Client> { IsSuccess = false, Message = "Unable to Find Client to delete" };
            }
            _clientRepository.DeleteClient(client.Id);
            return new BaseResponseModel<Client>
            {
                 IsSuccess = false, Message = "Deleted Sucessfully"   
            };
            
        }

        public BaseResponseModels<WorkerDTO> GetAllClientWorkers(int clientId)
        {
            var client = _clientRepository.GetClientById(clientId);
            if (client == null)
            {
                return new BaseResponseModels<WorkerDTO>
                {
                    IsSuccess = false,
                    Message = "Failed to get Client Workers",

                };
            }
            var clientWorker = _clientRepository.GetAllClientWorkers(clientId);
            return new BaseResponseModels<WorkerDTO>
            {
                Data = clientWorker,
                IsSuccess = true,
                Message = "Sucessfully returned all Client's Workers"
            };
        }

        public BaseResponseModel<Client> GetClientByEmailandPassword(string email, string password)
        {
            var client = GetClientByEmailandPassword(email, password);
            if(client == null)
            {
                return new BaseResponseModel<Client>
                {
                    
                    IsSuccess = false,
                    Message = "Failed to get Client",
                    
                };
            }
            else
            {
                return new BaseResponseModel<Client>
                {
                    Data = new Client
                    {
                        FirstName = client.Data.FirstName,
                        LastName = client.Data.LastName,
                        PhoneNumber = client.Data.PhoneNumber,
                        Address = client.Data.Address,
                        Email = client.Data.Email,
                        Gender = client.Data.Gender

                    },
                    IsSuccess = true,
                    Message = "Sucessfully Found",


                };
            }

        }

        public BaseResponseModel<Client> GetClientById(int Id)
        {
            
            var client = _clientRepository.GetClientById(Id);
            if(client == null)
            {
                new BaseResponseModel<Client>
                {
                    IsSuccess =false,
                    Message = "Failed"
                };
            }
            return new BaseResponseModel<Client>
            {
                Data = client,
                IsSuccess = true,
                Message = "Successfully returned Client"
            };
            
        }

        public BaseResponseModels<ContractDTO> GetClientContracts(int clientId)
        {
            var client = _clientRepository.GetClientById(clientId);
            if(client == null)
            {
                return new BaseResponseModels<ContractDTO>
                {
                    IsSuccess = false,
                    Message = "Failed to get Client Contracts",

                };
            }
            var clientContract = _clientRepository.GetClientContracts(clientId);
            return new BaseResponseModels<ContractDTO>
            {
                Data = clientContract,
                IsSuccess = true,
                Message = "Sucessfully returned all Client's Contract"
            };
            
                
        }

        public BaseResponseModel<Client> UpdateClient(ClientRequestModel request)
        {
            var client = _clientRepository.GetClientByEmailandPassword(request.Email, request.Password);
            if (client != null)
            {
                return new BaseResponseModel<Client>
                {
                    IsSuccess = false,
                    Message = "User Already Exists",

                };
            }

            else
            {
                Address address = new Address
                {
                    Country = request.Country,
                    State = request.State,
                    LocalGovernment = request.LocalGovernment,
                    Town = request.Town,

                };
                _addressRepository.UpdateAddress(address);
                Client clients = new Client
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Password = request.Password,
                    PhoneNumber = request.PhoneNumber,
                    Gender = request.Gender,
                    AddressId = address.Id,
                    Address = address,
                };

                _clientRepository.UpdateClient(clients);

            }
            return new BaseResponseModel<Client>
            {
                Data = new Client
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Gender = request.Gender,

                },
                IsSuccess = true,
                Message = "Client Updated sucessfully",

            };
        }
        public BaseResponseModel<ClientDTO> LogIn(ClientLoginRequestModel model)
        {
            var client = GetClientByEmailandPassword(model.Email, model.Password);
            if (client == null) { return new BaseResponseModel<ClientDTO> { Data = null, IsSuccess = false,Message = "Invalid Lodin Credentials" };  }
            return new BaseResponseModel<ClientDTO>
            {
                IsSuccess = true,
                Message = "Sucessfully Logged in"
            };
        }
    }
}
