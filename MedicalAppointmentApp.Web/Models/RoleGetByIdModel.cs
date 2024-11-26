using MedicalAppointmentApp.Persistance.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MedicalAppointmentApp.Web.Models
{
    public class RoleGetByIdModel : BaseApiResponseModel
    {
        public RoleModel? data { get; set; }
    }
}
