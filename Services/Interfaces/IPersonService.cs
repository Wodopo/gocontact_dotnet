using GoContactDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace GoContactDotNet.Services.Interfaces;

public interface IPersonService
{
    Task<List<Person>> GetAll();
    Task<Person?> Get(int id);
    Task<object?> GetAllComplete();
    Task<object?> GetComplete(int id);
}
