namespace MedicalAppointmentApp.Web.Models
{
    public class RoleViewModel
    {
        public int RoleId { get; set; } // Identificador único del rol

        public string? RoleName { get; set; } // Nombre del rol

        public DateTime CreatedAt { get; set; } // Fecha de creación del rol

        public DateTime UpdatedAt { get; set; } // Fecha de última actualización del rol

        public bool IsActive { get; set; } // Estado activo/inactivo del rol
    }
}
