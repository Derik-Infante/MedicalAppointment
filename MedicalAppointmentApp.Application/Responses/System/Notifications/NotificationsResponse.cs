
using MedicalAppointmentApp.Application.Core;
using MedicalAppointmentApp.Persistance.Models;

namespace MedicalAppointmentApp.Application.Responses.System.Notifications
{
    public class NotificationsResponse : BaseResponse
    {
        public List<NotificationModel>? Data { get; set; }
    }
}
