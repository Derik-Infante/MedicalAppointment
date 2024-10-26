using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;

namespace MedicalAppointmentApp.Persistance.Repositories
{
    public class RolesRepository : BaseRepository<Notifications>, INotificationsRepository
    {
        public RolesRepository (MedicalAppointmentsContext medicalAppointmentsContext) : base(medicalAppointmentsContext)
        {
        }

        public List<OperationResult> GetNotificationByNotificationID(int NotificationID)
        {
            throw new NotImplementedException();
        }

        public override Task<OperationResult> Update(Notifications entity)
        {
            return base.Update(entity);
        }

    }
}
