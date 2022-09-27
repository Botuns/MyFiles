using Authentication.Entities;
using Authentication.Models;
using Authentication.ReqAndResModels;
using System.Collections.Generic;

namespace Authentication
{
    public interface IUserServices
    {
        public UserResponseModel RegisterUser(UserRequestModels request);

        public UserResponseModel LoginUser(UserRequestModels request);

        public User FindById(int Id);

        public User FindByEmail(string userEmail);
        public User Update(UserRequestModels request);

        public IEnumerable<User> GetAllUser(int userId);

        public void Delete(int id);

    }
}