
namespace MedicalAppointmentApp.Application.Dtos.System.Notifications
{
    public class NotificationsUpdateDto :NotificationsDtoBase
    {
        public string? Message { get; set; }

        public DateTime SentAt { get; set; }

    }
}
