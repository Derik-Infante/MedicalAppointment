using System;
using System.Collections.Generic;

namespace MedicalAppointmentApp.Persistance.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int UserId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime? SentAt { get; set; }
}
