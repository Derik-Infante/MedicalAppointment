
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using MedicalAppointmentApp.Test.Context;
using System.Linq.Expressions;

namespace MedicalAppointmentApp.Test.NotificationsTest
{
    public class NotificationsMockRepository : INotificationsRepository
    {
        private readonly MedicalAppointmentsMockContext context;
        public NotificationsMockRepository(MedicalAppointmentsMockContext context) 
        {
            this.context = context;
        }
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

        public async Task<OperationResult> Save(Notifications entity)
        {
            OperationResult result = new OperationResult();

            try
            {

                if (entity == null)
                {
                    result.Success = false;
                    result.Message = "La entidad es requerida.";
                    return result;
                }

                if (string.IsNullOrEmpty(entity.Message))
                {
                    result.Success = false;
                    result.Message = "Mensaje requerido";
                    return result;
                }
                await this.context.AddAsync(entity);
                await this.context.SaveChangesAsync();

            }
            catch (Exception ex) 
            {
                result.Message = "Ocurrio un error guardando la notificación";
                result.Success = false;
            }

            return result;
        }

        public Task<OperationResult> Update(Notifications entity)
        {
            throw new NotImplementedException();
        }
    }
}
