using Microsoft.AspNetCore.Mvc;
using task.Application.UseCase.Task.Delete;
using task.Application.UseCase.Task.GetAll;
using task.Application.UseCase.Task.GetById;
using task.Application.UseCase.Task.Register;
using task.Application.UseCase.Task.Update;
using task.Communication.Requests;
using task.Communication.Responses;

namespace task.API.Controllers;

public class TaskController : BaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Create([FromBody]RequestTaskJson request)
    {
        RegisterTaskUseCase useCase = new RegisterTaskUseCase();
        ResponseTaskJson response = useCase.Execute(request: request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        UpdateTaskUseCase useCase = new UpdateTaskUseCase();
        ResponseTaskJson response = useCase.Execute(id: id, request: request);

        return Ok(response);
    }

    [HttpGet("get-all")]
    [ProducesResponseType(typeof(List<ResponseTaskJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetAll()
    {
        GetAllTaskUseCase useCase = new GetAllTaskUseCase();

        List<ResponseTaskJson> response = useCase.Execute();

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        GetByIdTaskUseCase useCase = new GetByIdTaskUseCase();

        ResponseTaskJson response = useCase.Execute(id: id);

        return Ok(response);
    }

    [HttpDelete]
    [ProducesResponseType(typeof(bool), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult DeleteById([FromRoute] int id)
    {
        DeleteTaskUseCase useCase = new DeleteTaskUseCase();

        bool response = useCase.Execute(id);

        if(response)
        {
            return NoContent();
        }
        else
        {
            return NotFound();
        }
    }
}