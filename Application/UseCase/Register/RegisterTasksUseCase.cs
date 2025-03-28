using Communication.Request;
using Communication.Response;

namespace Application.UseCase.Register
{
    public class RegisterTasksUseCase
    {
        public ResponseRegisteredTasksJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisteredTasksJson
            {
                Id = 1,
                Name = request.Name
            };
        }
    }
}
