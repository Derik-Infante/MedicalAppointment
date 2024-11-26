
namespace MedicalAppointmentApp.Application.Dtos.System.Roles
{
    public class RolesDtoBase
    {
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
