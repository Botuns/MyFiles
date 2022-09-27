using BotunsEntities.Contracts;

namespace BotunsEntities.Entities
{
    public class Complaint : AuditableEntity
    {
        public string? Problem{get; set;}
        public decimal SolutionFee{get; set;}
        public bool IsSolved{get; set;}
        public int ContractId{get; set;}
        public Contract? Contract{get; set;}
    }
}