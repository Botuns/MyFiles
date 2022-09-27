using Authentication.Contexts;
using Authentication.Entities;
using Authentication.Interfaces.Repository;
using Authentication.Models;
using Authentication.ReqAndResModels;
using System.Collections.Generic;
using System.Linq;

namespace Authentication.Implementations.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly ApplicationContext _dbContext;
        

        public UserServices(IUserRepository userRepository, ApplicationContext context)
        {
            _userRepository = userRepository;
            _dbContext = context;
            
        }
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public User FindByEmail(string userEmail)
        {
            throw new System.NotImplementedException();
        }

        public User FindById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public UserResponseModel LoginUser(UserRequestModels request)
        {
            var user = _userRepository.FindByUsername(request.UserName);

            if (user != null)
            {
                string password = (request.Password);
                if (user.Password.Equals(password))
                {
                    return new UserResponseModel
                    {
                        Data = new UserResponseModels
                        {
                            Id = user.Id,
                            UserName = user.UserName,
                            Password = user.Password,

                        },
                        Message = "Logged in sucessfully",
                        Status = true
                    };
                }
                return new UserResponseModel
                {
                    Message = "Invalid Credentials!",
                    Status = false
                    
                };


            }
            return new UserResponseModel
            {
                Message = "Invalid Credentials!",
                Status = false
                
            };



        }

        public UserResponseModel RegisterUser(UserRequestModels request)
        {
            var isexists =  _dbContext.Users.FirstOrDefault(u => u.UserName.Equals(request.UserName));
            if (isexists != null)
            {
                return new UserResponseModel
                {
                    Message = "User Already Registered!",
                    Status = false
                };
            }
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password,

            };
            _userRepository.Add(user);
            return new UserResponseModel
            {
                Message = "Registered Sucessfully",
                Status = true

            };
        }

        public User Update(UserRequestModels request)
        {
            throw new System.NotImplementedException();
        }
    }
}
