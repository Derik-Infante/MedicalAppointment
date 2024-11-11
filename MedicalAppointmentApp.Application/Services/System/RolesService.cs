
using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Roles;
using MedicalAppointmentApp.Application.Responses.System.Roles;

namespace MedicalAppointmentApp.Application.Services.System
{
    public class RolesService : IRolesService
    {
        public Task<RolesResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RolesResponse> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<RolesResponse> SaveAsync(RolesSaveDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<RolesResponse> UpdateAsync(RolesUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
