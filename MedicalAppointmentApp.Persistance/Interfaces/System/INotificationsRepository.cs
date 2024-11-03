using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;

namespace MedicalAppointmentApp.Persistance.Interfaces.System
{
    public interface INotificationsRepository : IBaseRepository<Notifications> 
    {
        Task<OperationResult> AddNotification(Notifications notification);
        Task<OperationResult> GetNotificationByNotificationID(int notificationID);
        Task<OperationResult> GetAllNotificationsByUserID(int userID);
        Task<OperationResult> DeleteNotification(int notificationID);
    }
}
