#nullable disable

using BotunsEntities.Contracts;

namespace BotunsEntities.Entities
{
    public class ClientContract : AuditableEntity
    {
        
        public int ClientId { get; set; }
        public int ContractId { get; set; }
        public Client Client { get; set; }
        public Contract Contract { get; set; }

    }
}
