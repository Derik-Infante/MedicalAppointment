namespace MedicalAppointmentApp.Web.Models
{
    public class NotificationCreateModel
    {
        public int notificationID { get; set; }
        public int userID { get; set; }
        public string? message { get; set; }
        public DateTime sentAt { get; set; }
    }
}
