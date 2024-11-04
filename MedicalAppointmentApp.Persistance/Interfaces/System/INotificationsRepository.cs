using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;

namespace MedicalAppointmentApp.Persistance.Interfaces.System
{
    public interface INotificationsRepository : IBaseRepository<Notifications> 
    {
        Task<OperationResult> AddNotification(Notifications notification); // Para agregar una nueva notificación
        Task<OperationResult> GetNotificationByNotificationID(int NotificationID); // Obtener notificación por ID
        Task<OperationResult> DeleteNotification(int NotificationID); // Eliminar notificación
        
    }
}
