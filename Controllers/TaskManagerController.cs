using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.useCases.Tasks.Delete;
using TaskManager.Application.useCases.Tasks.GetById;
using TaskManager.Communication.Responses;

namespace TaskManager.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskManagerController: ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] //requestBody) 
    {
        return NoContent();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var useCase = new GetTaskById();
        useCase.Execute(id);

        return Ok();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTaskById();
        useCase.Execute(id);

        return NoContent();
    }
}
