
#nullable disable

using BotunsEntities.Contracts;
namespace BotunsEntities.Entities
{
    public class Address : AuditableEntity
    {

        public string Description { get; set; }
        public string? City { get; set; }
        public string LGA { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Admin? Admin { get; set; }
        public Client Client { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public CompanyPersonnel Personnel { get; set; }

    }
}