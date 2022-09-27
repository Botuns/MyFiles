using Authentication.Models;

namespace Authentication.ReqAndResModels
{
    public class UserRequestModels
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

    }
    public class UserResponseModels : BaseResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


    }
    public class UserResponseModel : BaseResponse
    {
        public UserResponseModels Data { get; set; }
    }
    public class UserDTO
    {
        public int Id { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
