
namespace MedicalAppointmentApp.Persistance.Models;

public partial class NotificationModel
{
    public int NotificationId { get; set; }

    public int UserId { get; set; }

    public string? Message { get; set; } 

    public DateTime SentAt { get; set; }
}
