using Application.Extensions;
using DbFirst.Entities;
using DbFirst.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using web_api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DbFirstCursoEFContext>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("DBFirstCursoEF")));
builder.Services.AddApiDependencies();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
