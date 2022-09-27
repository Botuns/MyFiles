using BotunsEngineeringServices.DTOs;
using BotunsEngineeringServices.Entities;

namespace BotunsEngineeringServices.Interfaces.Services
{
    public interface IUserServices
    {
        //<My User>//
        public BaseResponseModel<UserDTO> CreateUser(UserReq req);
        //public BaseResponseModel<UserDTO> ExistsByEmail(string email);

        public BaseResponseModel<UserDTO> GetById(int id);

        public BaseResponseModel<UserDTO> GetByEmail(string email);
    }
}
