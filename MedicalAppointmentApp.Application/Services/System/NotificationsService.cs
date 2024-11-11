
using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Notifications;
using MedicalAppointmentApp.Application.Responses.System.Notifications;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Application.Services.System
{
    public class NotificationsService : INotificationsService
    {
        private readonly INotificationsRepository _notificationRepository;
        private readonly ILogger<NotificationsService> _logger;

        public NotificationsService(INotificationsRepository notificationsRepository,
                          ILogger<NotificationsService> logger)
        {
            _notificationRepository = notificationsRepository;
            _logger = logger;
        }
        public Task<NotificationsResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<NotificationsResponse> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<NotificationsResponse> SaveAsync(NotificationsSaveDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<NotificationsResponse> UpdateAsync(NotificationsUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
