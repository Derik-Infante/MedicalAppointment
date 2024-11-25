using MedicalAppointmentApp.Persistance.Models;

namespace MedicalAppointmentApp.Web.Models
{
    public class NotificationGetByIdModel: BaseApiResponseModel
    {
        public NotificationModel? data { get; set; }
    }
}
