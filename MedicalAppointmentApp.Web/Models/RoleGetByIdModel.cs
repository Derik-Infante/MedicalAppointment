using MedicalAppointmentApp.Persistance.Models;

namespace MedicalAppointmentApp.Web.Models
{
    public class RoleGetByIdModel : BaseApiResponseModel
    {
        public RoleModel? data { get; set; }
    }
}
