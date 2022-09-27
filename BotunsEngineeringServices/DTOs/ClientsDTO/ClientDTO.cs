using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Enums;
using System;

namespace BotunsEngineeringServices.DTOs.ClientsDTO
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string LocalGovernment { get; set; }
        public string Town { get; set; }

    }
    public class ClientRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string LocalGovernment { get; set; }
        public string Town { get; set; }
    }
    public class ClientLoginRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ClientBusinessFormRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public HireType HireType { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime ContractDate { get; set; }
        public TimeSpan ContractDuration { get; set; }
        public double ContractPrice { get; set; }
        public string ClientMessage { get; set; }
    }
    


}
