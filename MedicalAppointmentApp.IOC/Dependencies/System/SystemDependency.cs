
using MedicalAppointmentApp.Application.Base;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Persistance.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalAppointmentApp.IOC.Dependencies.System
{
    public static class SystemDependency
    {
        public static void AddConfigurationDependency(this IServiceCollection service)
        {
            service.AddScoped<INotificationsRepository, NotificationsRepository>();

            service.AddScoped<IRolesRepository, RolesRepository>();

            service.AddScoped<IStatusRepository, StatusRepository>();

            service.AddTransient<IBusService, BusService>();
        }

    }
}
