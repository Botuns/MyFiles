using BotunsEngApi.Enums;
using System;

namespace BotunsEngApi.DTOs.ContractDTO
{
    public class ContractDTO
    {
        public int Id { get; set; }
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime ContractDate { get; set; } = DateTime.UtcNow;
        public string ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public string ClientMessage { get; set; }
    }
    public class CreateContractRequestModel
    {
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public string ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public string ClientMessage { get; set; }
        public int Clientid { get; set; }
    }
}
