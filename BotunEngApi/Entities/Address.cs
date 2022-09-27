using System.Collections.Generic;

namespace BotunsEngApi.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string LocalGovernment { get; set; }
        public string Town { get; set; }
        public List<Client> ClientAddress { get; set; } = new List<Client>();
        public List<Admin> AdminAddress { get; set; } = new List<Admin>();
        public List<Worker> WorkerAddress { get; set; } = new List<Worker>();

    }
}
