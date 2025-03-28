using Communication.Enums.Priority;
using Communication.Enums.Status;

namespace Communication.Request
{
    public class RequestTaskJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ConclusionDateTime { get; set; }
        public StatusType Status { get; set; }
        public PriorityType Priority { get; set; }

    }
}
