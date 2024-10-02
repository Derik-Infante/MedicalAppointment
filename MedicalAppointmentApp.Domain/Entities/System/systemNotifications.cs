using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentApp.Domain.Entities.System
{
    internal class systemNotifications
    {
        int NotificationID { get; set; }
        
        int UserID { get; set; }

        string? Message { get; set; }

        DateTime SentAt { get; set; }
    }
}
