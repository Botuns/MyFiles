using BotunsEngineeringServices.Enums;
using System.Collections.Generic;

namespace BotunsEngineeringServices.Entities
{
    public class Client 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; } 
        public User user { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<ClientContracts>ClientContracts { get; set; } = new List<ClientContracts>();
        public List<WorkerClient> WorkerClient { get; set; } = new List<WorkerClient>();

    }
}
