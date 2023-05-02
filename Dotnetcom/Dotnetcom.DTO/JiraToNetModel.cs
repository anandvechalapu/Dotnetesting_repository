namespace Dotnetcom
{
    public class JiraToNetModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string TicketNumber { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}