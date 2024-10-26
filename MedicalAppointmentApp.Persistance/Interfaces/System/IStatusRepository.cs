

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;

namespace MedicalAppointmentApp.Persistance.Interfaces.System
{
    internal interface IStatusRepository : IBaseRepository<Notifications>
    {
        List<OperationResult> GetStatusByStatusID(int StatusID);
    }
}
