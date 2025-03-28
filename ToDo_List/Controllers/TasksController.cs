using Application.UseCase.Delete;
using Application.UseCase.GetAll;
using Application.UseCase.GetById;
using Application.UseCase.Register;
using Application.UseCase.Update;
using Communication.Request;
using Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace ToDo_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredTasksJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTaskJson request)
        {
            var response = new RegisterTasksUseCase().Execute(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTasksUseCase();

            var response = useCase.Execute();
            
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseRegisteredTasksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id) 
        {
            var useCase = new GetByIdUseCase();

            var response = useCase.Execute(id);

            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult Update(int id, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateByIdUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteByIdUseCase();

            useCase.Execute(id);

            return NoContent();
        }
    }
}
