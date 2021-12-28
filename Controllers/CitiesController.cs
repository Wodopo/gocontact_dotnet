using Microsoft.AspNetCore.Mvc;
using GoContactDotNet.Services.Interfaces;

namespace GoContactDotNet.Controllers;

[ApiController]
[Route("[controller]")]
public class CitiesController : ControllerBase
{
    private readonly ICityService _service;

    public CitiesController(ICityService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var cities = await _service.GetAll();
        return new OkObjectResult(cities);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var city = await _service.Get(id);
        if (city == null)
            return new NotFoundResult();
        return new OkObjectResult(city);
    }
}
