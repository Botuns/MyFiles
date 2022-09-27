using BotunsEntities.DTO;
using BotunsEntities.Interfaces.Repository;
using BotunsEntities.Interfaces.Service;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace BotunsEntities.Implementations.Services
{
    public class UserService :IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        public UserService(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }
        public async Task<BaseResponseModel<UserDTO>> Login(UserRequestModel model)
        {
            var user = await _userRepository.Get(x => x.Email == model.Email);

            if (user != null && BCrypt.Net.BCrypt.Verify(model.Password, user.Password))
            {
                var roles = _roleRepository.GetRolesByUserId(user.Id);
                return new BaseResponseModel<UserDTO>
                {
                    IsSuccess = true,
                    Message = "Sucesssfully Logged In",
                    Data = new UserDTO
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                        Roles = roles.Select(x => new RoleDTO
                        {
                            Name = x.Name,
                            Description = x.Description
                        }).ToList(),
                        
                    }
                };
            }
            return new BaseResponseModel<UserDTO>
            {
                Message = "Invalid email or password",
                IsSuccess = false
            };
        }
    }
}

