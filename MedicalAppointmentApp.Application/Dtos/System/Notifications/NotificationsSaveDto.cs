
namespace MedicalAppointmentApp.Application.Dtos.System.Notifications
{
    public class NotificationsSaveDto : NotificationsDtoBase
    {
        public string? Message { get; set; }
        public DateTime SentAt { get; set; }
    }
}
