using MedicalAppointmentApp.Persistance.Models;

namespace MedicalAppointmentApp.Web.Models
{
    public class NotificationGetResultModel
    {
        public object? message { get; set; }
        public bool success { get; set; }
        public List<NotificationModel>? data { get; set; }
    }
}
