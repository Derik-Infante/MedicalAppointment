namespace MedicalAppointmentApp.Web.Models
{
    public class NotificationViewModel
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string? Message { get; set; }
        public DateTime SentAt { get; set; }

        // Método para formatear la fecha
        public string GetFormattedDate()
        {
            return SentAt.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
