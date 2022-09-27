#nullable disable

using BotunsEntities.Contracts;

namespace BotunsEntities.Entities
{
    public class ClientProjectManager : AuditableEntity
    {
        
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public ProjectManager Manager { get; set; }
        public int ManagerId { get; set; }

    }
}
