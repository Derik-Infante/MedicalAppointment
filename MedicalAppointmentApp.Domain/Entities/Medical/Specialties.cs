using MedicalAppointmentApp.Domain.Base;

namespace MedicalAppointmentApp.Domain.Entities.Medical
{
    public sealed class Specialties : BaseEntity
    {
        public int SpecialtyID { get; set; }
        public string? SpecialtyName { get; set; }

    }
}
