using GoContactDotNet.Models;
using GoContactDotNet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GoContactDotNet.Services;

public class CompanyService : ICompanyService
{
    private readonly ILogger<Company> _logger;
    private readonly Context _context;

    public CompanyService(ILogger<Company> logger, Context context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<List<Company>> GetAll()
        => await _context.Companies.ToListAsync();

    public async Task<Company?> Get(int id)
        => await _context.Companies.FirstOrDefaultAsync(x => x.ID == id);
}
