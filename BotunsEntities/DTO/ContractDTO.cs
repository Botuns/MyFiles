using BotunsEntities.Enums;
using System;

namespace BotunsEntities.DTO
{
    public class ContractDTO
    {
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime ContractInitiatedDate { get; set; } = DateTime.UtcNow;
        public string ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public string ClientMessage { get; set; }
        public ContractStatus ContractStatus { get; set; }

        public string ContractDescription { get; set; }
        public int ProjectProgress { get; set; }
        public string ContractDocument { get; set; }
        public int ClientId { get; set; }

    }
    public class InitiateContractRequest
    {
        public int userId { get; set; }
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public string ContractDuration { get; set; }
        
        public string ClientMessage { get; set; }
        
    }
}
