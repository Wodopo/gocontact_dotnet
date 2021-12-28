using GoContactDotNet.Models;
using GoContactDotNet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GoContactDotNet.Services;

public class CityService : ICityService
{
    private readonly ILogger<Person> _logger;
    private readonly Context _context;

    public CityService(ILogger<Person> logger, Context context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<List<City>> GetAll()
        => await _context.Cities.ToListAsync();

    public async Task<City?> Get(int id)
        => await _context.Cities.FirstOrDefaultAsync(x => x.ID == id);
}
