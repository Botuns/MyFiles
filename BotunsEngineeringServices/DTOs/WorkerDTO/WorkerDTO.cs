using BotunsEngineeringServices.Entities;
using BotunsEngineeringServices.Enums;

namespace BotunsEngineeringServices.DTOs.WorkerDTO
{
    public class WorkerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WorkerRefNo { get; set; }
        public Address Address { get; set; }
        public WorkerType WorkerType { get; set; }
    }
    public class WorkerRequestModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WorkerRefNo { get; set; }
        public Address Address { get; set; }
    }
    public class WorkerLoginRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WorkerRefNo { get; set; }
    }
}
