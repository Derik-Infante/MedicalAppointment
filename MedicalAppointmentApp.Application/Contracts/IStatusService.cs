
using MedicalAppointmentApp.Application.Base;
using MedicalAppointmentApp.Application.Dtos.System.Status;
using MedicalAppointmentApp.Application.Responses.System.Status;

namespace MedicalAppointmentApp.Application.Contracts
{
    public interface IStatusService : IBaseService<StatusResponse, StatusSaveDto, StatusUpdateDto>
    {
    }
}
