using GoContactDotNet.Models;

namespace GoContactDotNet.Services.Interfaces;

public interface ICityService
{
    Task<List<City>> GetAll();
    Task<City?> Get(int id);
}
