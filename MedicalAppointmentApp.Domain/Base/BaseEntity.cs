
namespace MedicalAppointmentApp.Domain.Base
{
    public abstract class BaseEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime? UpadatedAt { get; set; }
        bool IsActive { get; set; }

    }
}
