namespace BotunsEntities.DTO
{
    public class ComplaintDTO
    {
        public string ComplaintTitle { get; set; }
        public string? Problem { get; set; }
        public decimal? SolutionFee { get; set; }
        public bool IsSolved { get; set; }
        public int ContractId { get; set; }
    }
    public class ComplaintRequestModel
    {
        public int ComplaintId { get; set; }
        public string ComplaintTitle { get; set; }
        public string ComplaintMessage { get; set; }
        public decimal? SolutionFee { get; set; }
        public int ContractId { get; set; }

    }
}
