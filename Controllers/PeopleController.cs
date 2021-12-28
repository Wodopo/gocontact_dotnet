using Microsoft.AspNetCore.Mvc;
using GoContactDotNet.Services.Interfaces;

namespace GoContactDotNet.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IPersonService _service;

    public PeopleController(IPersonService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var people = await _service.GetAll();
        return new OkObjectResult(people);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var person = await _service.GetComplete(id);
        if (person == null)
            return new NotFoundResult();
        return new OkObjectResult(person);
    }
}
