using MedicalAppointmentApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentApp.Domain.Entities.System
{
    [Table("roles", Schema = "sistema")]
    public class Roles: BaseEntity
    {
        [Key]
        public int RoleID { get; set; }

        public string? RoleName { get; set; }

    }
}
