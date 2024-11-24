using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Services.System;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MedicalAppointmentsContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MedicalAppointmentDb"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MedicalAppointmentDb"))));

builder.Services.AddScoped<INotificationsRepository, NotificationsRepository>();

builder.Services.AddTransient<INotificationsService, NotificationsService>();

builder.Services.AddScoped<IStatusRepository, StatusRepository>();

builder.Services.AddTransient<IStatusService, StatusService>();

builder.Services.AddScoped<IRolesRepository, RolesRepository>();

builder.Services.AddTransient<IRolesService, RolesService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();