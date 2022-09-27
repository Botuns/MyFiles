using BotunEngApi.Implementations.Repositories;
using BotunsEngApi.Contexts;
using BotunsEngApi.DTOs;
using BotunsEngApi.DTOs.ClientsDTO;
using BotunsEngApi.DTOs.ContractDTO;
using BotunsEngApi.DTOs.WorkerDTO;
using BotunsEngApi.Entities;
using BotunsEngApi.Implementations.Repositories;
using BotunsEngApi.Interfaces.Repositories;
using BotunsEngApi.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace BotunsEngApi.Implementations.Services
{
    public class ClientService : IClientServices
    {
        private readonly ApplicationContext _context;
        public IClientRepository _clientRepository;
        public ClientContractRepository _clientContract;
        public IContractRepository _contractRepository;
        public AddressRepository _addressRepository;
        public ClientService(ApplicationContext context, IClientRepository clientRepository, AddressRepository addressRepository, IContractRepository contractRepository, ClientContractRepository clientContractRepository)
        {
            _context = context;
            _clientRepository = clientRepository;
            _addressRepository = addressRepository;
            _contractRepository = contractRepository;
            _clientContract = clientContractRepository;
            
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
            //var contract = _context.Contracts.Find(request.ClientMessage);
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

                var clientt = _clientRepository.GetClientById(request.Clientid);
                ClientContracts contracts = new ClientContracts()
                {
                    ClientId = clientt.Id,
                    ContractId = contract1.Id,

                };
                _clientContract.CreateContracts(contracts);
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
                    Message = "Sucessful!",

                };
            }
            return new BaseResponseModel<Contract>
            {
                IsSuccess = false,
                Message = "UnSucessful!",


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
            var client = _clientRepository.GetClientByEmailandPassword(email, password);
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
                        FirstName = client.FirstName,
                        LastName = client.LastName,
                        PhoneNumber = client.PhoneNumber,
                        Address = client.Address,
                        Email = client.Email,
                        Gender = client.Gender

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
                Data = clientContract.Select(a => new ContractDTO
                {
                    ContractDate = a.ContractDate,
                    ContractDuration = a.ContractDuration,
                    ContractPrice = a.ContractPrice,
                    HireType = a.HireType,
                    ServiceType = a.ServiceType,
                    ClientMessage = a.ClientMessage,


                }).ToList(),
            IsSuccess = true,
                Message = "Sucessfully returned all Client's Contract"
            };
            
                
        }

        public BaseResponseModel<Client> UpdateClient(ClientRequestModel request)
        {
            var client = _clientRepository.GetClientByEmailandPassword(request.Email, request.Password);
            if (client== null)
            {
                return new BaseResponseModel<Client>
                {
                    IsSuccess = false,
                    Message = "User dosent exist"

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
    }
}
