using Microsoft.AspNetCore.Mvc;
using GoContactDotNet.Services.Interfaces;

namespace GoContactDotNet.Controllers;

[ApiController]
[Route("[controller]")]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyService _service;

    public CompaniesController(ICompanyService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var companies = await _service.GetAll();
        return new OkObjectResult(companies);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var company = await _service.Get(id);
        if (company == null)
            return new NotFoundResult();
        return new OkObjectResult(company);
    }
}
