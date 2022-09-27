using BotunsEntities.DTO;
using BotunsEntities.Entities;
using BotunsEntities.Identity;
using BotunsEntities.Interfaces.Repository;
using BotunsEntities.Interfaces.Service;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BotunsEntities.Implementations.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        //private readonly IEmailSender _email;
        private readonly IUserRepository _userRepository;
        //private readonly IImageRepository _imageRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IWebHostEnvironment _webHost;
        
        //private readonly ICategoryRepository _categoryRepository;
        public ClientService(IWebHostEnvironment webHost, IRoleRepository roleRepository, IAddressRepository addressRepository, IUserRepository userRepository, IClientRepository clientRepository)
        {
            //_adminRepository = adminRepository;
            _userRepository = userRepository;
            _clientRepository = clientRepository;
            _addressRepository = addressRepository;
            _roleRepository = roleRepository;
            _webHost = webHost;
            
        }

        public Task<BaseResponseModel<ClientDTO>> GetClientInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModels<ContractDTO>> GetContractsByClientId(int id)
        {
            throw new NotImplementedException();
        }

        

        public Task<int> NoOfOngoingProject(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<int> ProjectProgress(int clientId)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponseModel<ClientDTO>> RegisterClient(ClientRequestModel model)
        {
            var client = await _userRepository.GetEmail(model.Email);
            if (client != null)
            {
                return new BaseResponseModel<ClientDTO>
                {
                    Message = "Email or password already exist",
                    IsSuccess = false,
                };
            }
            var user = new User
            {
                UserName = $"{model.FirstName} {model.LastName}",
                Password = BCrypt.Net.BCrypt.HashPassword(model.Password),
                Email = model.Email,


            };
            Console.WriteLine($"{user.Password}");

            /*var addUser =*/
            await _userRepository.Register(user);
            var role = await _roleRepository.Get(x => x.Name == "client");
            if (role == null)
            {
                return new BaseResponseModel<ClientDTO>
                {
                    Message = "Role not found",
                    IsSuccess = false
                };
            }
            var userRole = new UserRole
            {
                User = user,
                UserId = user.Id,
                Role = role,
                RoleId = role.Id
            };
            user.UserRoles.Add(userRole);
            /*var updateUser =*/
            await _userRepository.Update(user);

            var address = new Address
            {
                Country = model.Country,
                State = model.State,
                LGA = model.LGA,
                Description = "All addresses are provided by the user"
            };
            /*var addAddress =*/
            await _addressRepository.Register(address);
            var newClient = new Client
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                CreatedBy = user.Id,
                LastModifiedBy = user.Id,
                IsDeleted = false,
                UserId = user.Id,
                AddressId = address.Id


            };
            /*var addadmin =*/
            await _clientRepository.Register(newClient);
            var folderPath = Path.Combine(Directory.GetCurrentDirectory() + "\\Images\\");
            if (Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (model.Image != null)
            {

                var fileName = Path.GetFileNameWithoutExtension(model.Image.FileName).ToString();
                var filePath = Path.Combine(folderPath, model.Image.FileName);
                var extension = Path.GetExtension(model.Image.FileName);
                if (Directory.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(stream);
                    }
                    newClient.Image = fileName;
                }
            }
            await _clientRepository.Update(newClient);
            if(newClient.FirstName != null)
            {
                return new BaseResponseModel<ClientDTO>
                {
                    Message = "client Successfully registered",
                    IsSuccess = true,
                };
            }
            
            return new BaseResponseModel<ClientDTO>
            {
                Message = "Value cannot be null ",
                IsSuccess = false,
            };
        }
    }
}
