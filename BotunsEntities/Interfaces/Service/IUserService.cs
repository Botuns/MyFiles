using BotunsEntities.DTO;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Service
{
    public interface IUserService
    {
        Task<BaseResponseModel<UserDTO>> Login(UserRequestModel model);
    }
}
