
namespace MedicalAppointmentApp.Application.Dtos.System.Roles
{
    public class GetRolesDto : RolesDtoBase
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
