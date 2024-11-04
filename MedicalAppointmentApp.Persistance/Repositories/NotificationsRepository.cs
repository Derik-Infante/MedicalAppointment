using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Persistance.Repositories
{
    public class NotificationsRepository : BaseRepository<Notifications>, INotificationsRepository
    {
        private readonly MedicalAppointmentsContext _medicalAppointmentsContext;
        private readonly ILogger<NotificationsRepository> _logger;

        public NotificationsRepository(MedicalAppointmentsContext medicalAppointmentsContext, ILogger<NotificationsRepository> logger)
            : base(medicalAppointmentsContext)
        {
            _medicalAppointmentsContext = medicalAppointmentsContext;
            _logger = logger;
        }

        public async Task<OperationResult> AddNotification(Notifications notification)
        {
            return await Save(notification);
        }

        public async Task<OperationResult> GetNotificationByNotificationID(int NotificationID)
        {
            return await GetEntityBy(NotificationID);
        }

        public async Task<OperationResult> GetAllNotificationsByUserID(int UserID)
        {
            try
            {
                var notifications = await (from n in _medicalAppointmentsContext.Notifications
                                           join u in _medicalAppointmentsContext.Users
                                           on n.UserID equals u.UserID
                                           where n.UserID == UserID
                                           select new
                                           {
                                               n.NotificationID,
                                               n.Message,
                                               UserFirstName = u.FirstName,
                                               UserLastName = u.LastName
                                           }).ToListAsync();

                return new OperationResult { Success = true, Data = notifications };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener las notificaciones del usuario.");
                return new OperationResult { Success = false, Message = "Error al obtener las notificaciones." };
            }
        }

        public async Task<OperationResult> DeleteNotification(int NotificationID)
        {
            var notification = await _medicalAppointmentsContext.Notifications.FindAsync(NotificationID);

            if (notification == null)
            {
                return new OperationResult { Success = false, Message = "Notificación no encontrada." };
            }

            return await Remove(notification);
        }

        
    }
}
