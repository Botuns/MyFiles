using BotunsEngApi.Enums;
using System.Collections.Generic;

namespace BotunsEngApi.Entities
{
    public class Worker 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WorkerRefNo { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public WorkerType WorkerType { get; set; }
        public List<WorkerClient> WorkerClient { get; set; } = new List<WorkerClient>();



    }
}
