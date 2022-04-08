using Application;
using Domain.Contracts.Application;
using Domain.Contracts.External;
using Domain.Contracts.Repository;
using Domain.Contracts.Service;
using Domain.Service;
using Domain.VO;
using Infra.External;
using Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<IUserApplication, UserApplication>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IMaling, Maling>();

var appconfig = new AppConfig();
appconfig.User = "teste";
appconfig.Key  = "key teste";

builder.Services.AddSingleton<AppConfig>(appconfig);


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
