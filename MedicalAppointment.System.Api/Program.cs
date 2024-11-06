using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MedicalAppointmentsContext>(options => options.UseMySql(
        builder.Configuration.GetConnectionString("MedicalAppointmentDb"),
        new MySqlServerVersion(new Version(8, 4, 2)) 
    ));

//El registro de cada una de las dependecias Repositorios de System. //

builder.Services.AddScoped<INotificationsRepository, NotificationsRepository>();
builder.Services.AddScoped<IRolesRepository, RolesRepository>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
