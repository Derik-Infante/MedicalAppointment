
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using System.Linq.Expressions;

namespace MedicalAppointmentApp.Test.NotificationsTest
{
    public class NotificationsMockRepository : INotificationsRepository
    {
        public Task<OperationResult> AddNotification(Notifications notification)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> DeleteNotification(int NotificationID)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Exist(Expression<Func<Notifications, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Notifications>> GetAllNotifications()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetNotificationByNotificationID(int NotificationID)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Remove(Notifications entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Save(Notifications entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Update(Notifications entity)
        {
            throw new NotImplementedException();
        }
    }
}
