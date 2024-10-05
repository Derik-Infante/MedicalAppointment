using MedicalAppointmentApp.Domain.Base;

namespace MedicalAppointmentApp.Domain.Entities.System
{
    public class Roles: BaseEntity
    { 
        public int RoleID { get; set; }

        public string? RoleName { get; set; }

    }
}
