namespace YardManagementSim.Models
{
    public class YardMove
    {
        public int Id { get; set; }
        public string FromSlip { get; set; } = "";
        public string ToSlip { get; set; } = "";
        public string Trailer { get; set; } = "";
        public DateTime MovedAt { get; set; } = DateTime.Now;
        public bool Completed { get; set; } = false;
    }
}
