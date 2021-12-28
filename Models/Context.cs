using Microsoft.EntityFrameworkCore;
namespace GoContactDotNet.Models;

public class Context : DbContext
{
#pragma warning disable CS8618
    public Context(DbContextOptions<Context> options)
        : base(options) { }
#pragma warning restore CS8618

    public DbSet<Person> People { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<PersonCity> PersonCity { get; set; }
    public DbSet<PersonCompany> PersonCompany { get; set; }
}