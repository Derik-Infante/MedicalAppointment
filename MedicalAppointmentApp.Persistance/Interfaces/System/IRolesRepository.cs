using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;

namespace MedicalAppointmentApp.Persistance.Interfaces.System
{
    public interface IRolesRepository : IBaseRepository<Notifications>
    {
        List<OperationResult> GetRoleByRoleID(int RoleID);
    }
}
