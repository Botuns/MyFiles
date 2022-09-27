using BotunsEntities.DTO;

namespace BotunsEntities.Authentication
{
    public interface IJWTAuthentication
    {
        public string GenerateToken(BaseResponseModel<UserDTO> model);
    }
}
