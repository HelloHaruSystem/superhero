using Microsoft.EntityFrameworkCore;
using super_hero.Data;

var builder = WebApplication.CreateBuilder(args);

// configure to use PostgreSQL
builder.Services.AddDbContext<SuperheroDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
