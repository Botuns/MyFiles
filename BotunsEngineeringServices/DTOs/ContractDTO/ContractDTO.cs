using BotunsEngineeringServices.Enums;
using System;

namespace BotunsEngineeringServices.DTOs.ContractDTO
{
    public class ContractDTO
    {
        public int Id { get; set; }
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime ContractDate { get; set; }
        public TimeSpan ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public string ClientMessage { get; set; }
    }
    public class CreateContractRequestModel
    {
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime ContractDate { get; set; }
        public TimeSpan ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public string ClientMessage { get; set; }
    }
}
