

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;

namespace MedicalAppointmentApp.Persistance.Repositories
{
    internal class StatusRepository : BaseRepository<Notifications>, INotificationsRepository
    {
        public StatusRepository(MedicalAppointmentsContext medicalAppointmentsContext) : base(medicalAppointmentsContext)
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
