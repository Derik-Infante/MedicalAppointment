
namespace MedicalAppointmentApp.Application.Dtos.System.Notifications
{
    public class NotificationsSaveDto
    {
        public int UserID { get; set; }
        public string? Message { get; set; }
        public DateTime SentAt { get; set; }
    }
}
