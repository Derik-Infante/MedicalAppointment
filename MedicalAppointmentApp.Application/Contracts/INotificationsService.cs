
using MedicalAppointmentApp.Application.Base;
using MedicalAppointmentApp.Application.Dtos.System.Notifications;
using MedicalAppointmentApp.Application.Responses.System.Notifications;

namespace MedicalAppointmentApp.Application.Contracts
{
    public interface INotificationsService : IBaseService<NotificationsResponse, NotificationsSaveDto, NotificationsUpdateDto>
    {
    }
}
