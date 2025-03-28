using Communication.Enums.Priority;
using Communication.Enums.Status;

namespace Communication.Response
{
    public class ResponseTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ConclusionDateTime { get; set; }
        public StatusType Status { get; set; }
        public PriorityType Priority { get; set; }
    }
}
