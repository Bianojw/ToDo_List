using Communication.Enums.Status;
using Communication.Response;

namespace Application.UseCase.GetAll
{
    public class GetAllTasksUseCase
    {
        public ResponseAllTasksJson Execute()
        {
            return new ResponseAllTasksJson
            {
                Tasks = 
                [
                    new ResponseShortTasksJson
                    {
                        Id = 1,
                        Name = "Task 1",
                        Status = StatusType.Pending,
                        ConclusionDateTime = DateTime.Now
                    },
                ]
            };
        }

    }
}
