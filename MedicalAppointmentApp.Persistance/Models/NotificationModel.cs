

namespace MedicalAppointmentApp.Persistance.Models;

public partial class NotificationModel
{
    public int NotificationId { get; set; }

    public int UserId { get; set; }

    public string? Message { get; set; } 

    public DateTime SentAt { get; set; }

    public static explicit operator NotificationModel(List<NotificationModel>? v)
    {
        throw new NotImplementedException();
    }
}
