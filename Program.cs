using GoContactDotNet.Models;
using GoContactDotNet.Services;
using GoContactDotNet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<Context>(options
        => options.UseNpgsql("HOST=localhost;Port=5432;Pooling=true;Database=gocontact;User Id=postgres;Password=26332633;"));

builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
