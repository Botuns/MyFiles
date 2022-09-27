using BotunsEngineeringServices.Enums;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;

namespace BotunsEngineeringServices.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime ContractDate { get; set; }
        public TimeSpan ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public List<ClientContracts> ClientContracts { get; set; } = new List<ClientContracts>();
        public string ClientMessage { get; set; }


    }
}
