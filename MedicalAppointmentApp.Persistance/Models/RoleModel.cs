
namespace MedicalAppointmentApp.Persistance.Models;

public partial class RoleModel
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; } 

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsActive { get; set; }
}
