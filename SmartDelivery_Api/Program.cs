using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SmartDelivery_App.Interfaces;
using SmartDelivery_App.Services;
using SmartDelivery_Infra.Context;
using SmartDelivery_Infra.Repositories;
using SmartDelivery_Infra.Repositories.ReposInterFace;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddDbContext<SmartDeliveryDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("SmartDeliveryConnectionString"))
    );

builder.Services.AddScoped<ISmartDeliveryRepos, SmartDeliveryRepos>();
builder.Services.AddScoped<ISmartDeliveryServices, SmartDeliveryServices>();

builder.Services.AddAutoMapper(typeof(Program));

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
