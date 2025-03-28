using Communication.Enums.Status;

namespace Communication.Response
{
    public class ResponseShortTasksJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public StatusType Status { get; set; }
        public DateTime ConclusionDateTime { get; set; }

    }
}
