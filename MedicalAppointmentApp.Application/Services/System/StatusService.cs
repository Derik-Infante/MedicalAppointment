
using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Status;
using MedicalAppointmentApp.Application.Responses.System.Status;

namespace MedicalAppointmentApp.Application.Services.System
{
    public class StatusService : IStatusService
    {
        public Task<StatusResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StatusResponse> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<StatusResponse> SaveAsync(StatusSaveDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<StatusResponse> UpdateAsync(StatusUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
