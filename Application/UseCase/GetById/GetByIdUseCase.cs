using Communication.Enums.Status;
using Communication.Response;

namespace Application.UseCase.GetById
{
    public class GetByIdUseCase
    {
        public ResponseTaskJson Execute(int id)
        {
            return new ResponseTaskJson
            {
                Id = 1,
                Name = "Task 1",
                Status = StatusType.Pending,
                ConclusionDateTime = DateTime.UtcNow,
            };
        }
    }
}
