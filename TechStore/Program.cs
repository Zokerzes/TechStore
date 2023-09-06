using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TechStore.Data.AppDbContext>(options =>
{
    string connStr = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connStr);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
