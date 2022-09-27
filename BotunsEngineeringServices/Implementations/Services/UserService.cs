using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.DTOs;
using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Interfaces.Services;

namespace BotunsEngineeringServices.Implementations.Services
{
    public class UserService : IUserServices
    {
        private readonly ApplicationContext _context;
        public IUserServices _userServices;
        public UserService(ApplicationContext context,IUserServices userServices)
        {
            _context = context;
            _userServices = userServices;
        }
        public BaseResponseModel<UserDTO> CreateUser(UserReq req)
        {
            var newUser = _userServices.GetByEmail(req.Email);
            if (newUser == null)
            {
                User user = new User
                {
                    Password = req.Password,
                    Email = req.Email,
                    UserName = req.UserName
                };
            }
            return new BaseResponseModel<UserDTO> { Message = "gdvb" };
        }

        public BaseResponseModel<UserDTO> GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public BaseResponseModel<UserDTO> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
