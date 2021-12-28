using GoContactDotNet.Models;

namespace GoContactDotNet.Services.Interfaces;

public interface ICompanyService
{
    Task<List<Company>> GetAll();
    Task<Company?> Get(int id);
}
