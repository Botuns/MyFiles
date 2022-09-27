#nullable disable

using BotunsEntities.Contracts;
using BotunsEntities.Enums;
using System;
using System.Collections.Generic;

namespace BotunsEntities.Entities
{
    public class Contract : AuditableEntity
    {
        
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime ContractInitiatedDate { get; set; } = DateTime.UtcNow;
        public string ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public List<ClientContract> ClientContracts { get; set; } = new List<ClientContract>();
        public string ClientMessage { get; set; }
        public ContractStatus ContractStatus { get; set; }

        public string ContractDescription { get; set; }
        public int ProjectProgress { get; set; }
        public string ContractDocument { get; set; }
        public int ClientId { get; set; }

    }
}
