using Authentication.Models;

namespace Authentication.Entities
{
    public class User 
    {
        public int Id { get; protected set; }
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}
