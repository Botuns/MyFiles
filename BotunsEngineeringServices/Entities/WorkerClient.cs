namespace BotunsEngineeringServices.Entities
{
    public class WorkerClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int WorkerId { get; set; }
        public Client Client { get; set; }
        public Worker Worker { get; set; }
    }
}
