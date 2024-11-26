using MedicalAppointmentApp.Persistance.Models;

namespace MedicalAppointmentApp.Web.Models
{
    public class RolesGetAllResultModel : BaseApiResponseModel
    {
        public List<RoleModel>? data { get; set; }
    }
}
