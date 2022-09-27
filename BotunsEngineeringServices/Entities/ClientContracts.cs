namespace BotunsEngineeringServices.Entities
{
    public class ClientContracts
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ContractId { get; set; }
        public Client Client { get; set; }
        public Contract Contract { get; set; }
    }
}
