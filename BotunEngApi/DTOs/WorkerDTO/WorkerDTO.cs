using BotunsEngApi.Entities;
using BotunsEngApi.Enums;

namespace BotunsEngApi.DTOs.WorkerDTO
{
    public class WorkerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WorkerRefNo { get; set; }
       
        public WorkerType WorkerType { get; set; }
        
        public string Country { get; set; }
        public string State { get; set; }
        public string LocalGovernment { get; set; }
        public string Town { get; set; }
    }
    public class WorkerRequestModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WorkerRefNo { get; set; }
        
        public string Country { get; set; }
        public string State { get; set; }
        public string LocalGovernment { get; set; }
        public string Town { get; set; }
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
