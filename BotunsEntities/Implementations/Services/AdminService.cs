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
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IUserRepository _userRepository;
        //private readonly IImageRepository _imageRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IWebHostEnvironment _webHost;
        //private readonly ICategoryRepository _categoryRepository;
        public AdminService(IWebHostEnvironment webHost, IAdminRepository adminRepository, IRoleRepository roleRepository, IAddressRepository addressRepository, IUserRepository userRepository)
        {
            _adminRepository = adminRepository;
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            _roleRepository = roleRepository;
            _webHost = webHost;

        }

        public Task<BaseResponseModel<AdminDTO>> ActivateAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModel<AdminDTO>> DeActivateAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModel<AdminDTO>> GetAdminInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModels<AdminDTO>> GetAllActivatedAdmins()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModels<AdminDTO>> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModels<AdminDTO>> GetAllDeactivatedAdmins()
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponseModel<AdminDTO>> RegisterAdmin(AdminRequestModel model)
        {
            var admin = await _userRepository.GetEmail(model.Email);
            if (admin != null)
            {
                return new BaseResponseModel<AdminDTO>
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
            var role = await _roleRepository.Get(x => x.Name == "admin");
            if (role == null)
            {
                return new BaseResponseModel<AdminDTO>
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
            var newAdmin = new Admin
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
            await _adminRepository.Register(newAdmin);
            var folderPath = Path.Combine(Directory.GetCurrentDirectory() + "\\Images\\");
            if (Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (model.Image != null)
            {

                var fileName = Path.GetFileNameWithoutExtension(model.Image.FileName);
                var filePath = Path.Combine(folderPath, model.Image.FileName);
                var extension = Path.GetExtension(model.Image.FileName);
                if (Directory.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(stream);
                    }
                    newAdmin.Image = fileName;
                }
            }
            await _adminRepository.Update(newAdmin);
            return new BaseResponseModel<AdminDTO>
            {
                Message = "admin Successfully registered",
                IsSuccess = true,
            };
            return new BaseResponseModel<AdminDTO>
            {
                Message = "Value cannot be null ",
                IsSuccess = false,
            };
        }


        public Task<BaseResponseModel<AdminDTO>> UpdateAdmin(UpdateAdminRequestModel model, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
