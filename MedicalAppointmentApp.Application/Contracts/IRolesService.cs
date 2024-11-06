
using MedicalAppointmentApp.Application.Base;
using MedicalAppointmentApp.Application.Dtos.System.Roles;
using MedicalAppointmentApp.Application.Responses.System.Roles;

namespace MedicalAppointmentApp.Application.Contracts
{
    public interface IRolesService : IBaseService<RolesResponse, RolesSaveDto, RolesUpdateDto>
    {
    }
}
