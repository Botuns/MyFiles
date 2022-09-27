using System.Collections.Generic;

namespace BotunsEntities.DTO
{
    public class UserRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public ICollection<RoleDTO> Roles { get; set; } = new HashSet<RoleDTO>();
    }
    public class LoginResponse
    {
        public BaseResponseModel<UserDTO> Data { get; set; }
        public string Token { get; set; }
    }
}
