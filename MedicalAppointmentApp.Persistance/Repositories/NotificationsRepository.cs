

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;

namespace MedicalAppointmentApp.Persistance.Repositories
{
    public class NotificationsRepository : BaseRepository<Notifications>, INotificationsRepository
    {
        public NotificationsRepository(MedicalAppointmentsContext medicalAppointmentsContext): base(medicalAppointmentsContext)
        {
        }

        public override Task<OperationResult> Update(Notifications entity)
        {
            return base.Update(entity);
        }

    }
}
