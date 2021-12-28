using GoContactDotNet.Models;
using GoContactDotNet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GoContactDotNet.Services;

public class PersonService : IPersonService
{
    private readonly ILogger<Person> _logger;
    private readonly Context _context;

    public PersonService(ILogger<Person> logger, Context context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<List<Person>> GetAll()
        => await _context.People.ToListAsync();

    public async Task<Person?> Get(int id)
        => await _context.People.FirstOrDefaultAsync(x => x.ID == id);

    public async Task<object?> GetAllComplete()
    {
        var ctx = _context;
        var x = from person in ctx.People
                from personCity in ctx.PersonCity.Where(x => x.PersonID == person.ID).DefaultIfEmpty()
                from city in ctx.Cities.Where(x => x.ID == personCity.CityID).DefaultIfEmpty()
                from personCompany in ctx.PersonCompany.Where(x => x.PersonID == person.ID).DefaultIfEmpty()
                from company in ctx.Companies.Where(x => x.ID == personCompany.CompanyID).DefaultIfEmpty()
                select new { Id = person.ID, Name = person.Name, Email = person.Email, city, company };
        return await x.ToListAsync();
    }

    public async Task<object?> GetComplete(int id)
    {
        var ctx = _context;
        var x = from person in ctx.People
                where person.ID == id
                from personCity in ctx.PersonCity.Where(x => x.PersonID == person.ID).DefaultIfEmpty()
                from city in ctx.Cities.Where(x => x.ID == personCity.CityID).DefaultIfEmpty()
                from personCompany in ctx.PersonCompany.Where(x => x.PersonID == person.ID).DefaultIfEmpty()
                from company in ctx.Companies.Where(x => x.ID == personCompany.CompanyID).DefaultIfEmpty()
                select new { Id = person.ID, Name = person.Name, Email = person.Email, city, company };
        try
        {
            return await x.SingleAsync();
        }
        catch (Exception)
        {
            return null;
        }
    }
}
