using MedicalAppointmentApp.Persistance.Models;

namespace MedicalAppointmentApp.Web.Models
{
    public class NotificationGetAllResultModel : BaseApiResponseModel
    {
        public List<NotificationModel>? data { get; set; }
    }
}
